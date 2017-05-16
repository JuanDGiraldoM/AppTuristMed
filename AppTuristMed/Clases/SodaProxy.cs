using SODA;
using System;
using System.Data.OleDb;

namespace AppTuristMed.Clases
{
    class SodaProxy : IDisposable
    {
        private SodaClient client;
        public OleDbConnection Connection { get; set; }
        public OleDbCommand Command { get; set; }
        private OleDbDataAdapter Adapter;
        private const string URL_PORTAL = "www.datos.gov.co";
        private const string APP_TOKEN = "gWJl5WoNZW5ZVjc3f3KX87p4p";
        private const string DATASET_HOSPITALES = "g373-n3yy";
        private const string DATASET_ESTACIONES = "3a4x-4hwu";
        private const string DATASET_ESTACIONESGAS = "wv4z-3t2h";
        private const string DATASET_WIFI1 = "4ai7-uijz";
        private const string DATASET_WIFI2 = "ys2m-cts9";
        private const string DATASET_HOTELES = "y37i-bm2e";


        public SodaProxy()
        {
            client = new SodaClient(URL_PORTAL, APP_TOKEN);
            Connection = new OleDbConnection();
            Command = new OleDbCommand();
            Adapter = new OleDbDataAdapter();
            Adapter.InsertCommand = new OleDbCommand();
            Adapter.DeleteCommand = new OleDbCommand();
            Adapter.DeleteCommand.Connection = Connection;
            Adapter.InsertCommand.Connection = Connection;
        }

        public void ActualizarHospitales()
        {
            var dataset = client.GetResource<Hospital>(DATASET_HOSPITALES);
            var soql = new SoqlQuery().Select("*").Where("c_digo_regi_n ='01'");
            var datos = dataset.Query<Hospital>(soql);
            Connection.Open();
            Adapter.DeleteCommand.CommandText = "delete * from Hospitales";
            Adapter.DeleteCommand.ExecuteNonQuery();
            int i = 1;
            foreach(Hospital hospital in datos)
            {
                Adapter.InsertCommand.CommandText = "insert into Hospitales (Id, Municipio, Nombre_Sede, Direccion, Telefono, Email)" +
                    "values ('" + i++ + "','" + hospital.Municipio + "','" + hospital.NombreSede + "','" + hospital.Direccion + "','" + hospital.Telefono + "','" +
                    hospital.Email + "')";
                Adapter.InsertCommand.ExecuteNonQuery();
                //Console.WriteLine(hospital.NombreSede + "\t" + hospital.Ubicacion.Longitude.Length);
            }
            Connection.Close();
        }

        public void ActualizarEstaciones()
        {
            var dataset = client.GetResource<Estacion>(DATASET_ESTACIONES);
            var soql = new SoqlQuery().Select("*").Where("municipio = 'MEDELLIN'");
            var datos = dataset.Query<Estacion>(soql);
            Connection.Open();
            Adapter.DeleteCommand.CommandText = "delete * from Estaciones";
            Adapter.DeleteCommand.ExecuteNonQuery();
            int i = 0;
            foreach (Estacion estacion in datos)
            {
                Adapter.InsertCommand.CommandText = "insert into Estaciones (Id, Ciudad, Estacion, Bandera, Direccion, Producto, Precio)" +
                    "values ('" + ++i + "','" + estacion.Municipio + "','" + estacion.NombreComercial + "','" + estacion.Bandera + "','" + estacion.Direccion +
                    "','" + estacion.Producto + "','" + estacion.Precio + "')";
                Adapter.InsertCommand.ExecuteNonQuery();
            }
            Connection.Close();
            ActualizarEstacionesGas(i);
        }

        private void ActualizarEstacionesGas(int i)
        {
            var dataset = client.GetResource<EstacionGas>(DATASET_ESTACIONESGAS);
            var datos = dataset.GetRows();
            Connection.Open();
            foreach (EstacionGas estacion in datos)            
            {
                Adapter.InsertCommand.CommandText = "insert into Estaciones (Id, Ciudad, Estacion, Bandera, Direccion, Producto, Detalles)" +
                    "values ('" + ++i + "','" + estacion.Ciudad.ToUpper() + "','" + estacion.Estacion.ToUpper() + "','EPM','" + estacion.Direccion + "','GAS','" +
                    estacion.Ubicacion + "')";
                Adapter.InsertCommand.ExecuteNonQuery();
                //Console.WriteLine(estacion.Coordenadas.Latitude.ToCharArray());
            }
            Connection.Close();
        }

        public void ActualizarZonasWiFi()
        {
            var dataset = client.GetResource<WiFi>(DATASET_WIFI1);
            var datos = dataset.GetRows();
            Connection.Open();
            Adapter.DeleteCommand.CommandText = "delete * from Wifi";
            Adapter.DeleteCommand.ExecuteNonQuery();
            int i = 0;
            foreach(WiFi wifi in datos)
            {
                Adapter.InsertCommand.CommandText = "insert into Wifi (Id, Comuna, Barrio, Sitio, Direccion)" +
                    "values ('" + ++i + "','" + wifi.Comuna + "','" + wifi.Barrio + "','" + wifi.NombreSitio +
                    "','" + wifi.Direccion + "')";
                Adapter.InsertCommand.ExecuteNonQuery();
                //Console.WriteLine(wifi.Ubicacion.Latitude.ToCharArray());
            }
            Connection.Close();
            ActualizarZonasWifi1(i);

        }

        private void ActualizarZonasWifi1(int i)
        {
            var dataset = client.GetResource<WiFi>(DATASET_WIFI2);
            var datos = dataset.GetRows();
            Connection.Open();
            foreach (WiFi wifi in datos)
            {
                Adapter.InsertCommand.CommandText = "insert into Wifi (Id, Comuna, Barrio, Sitio, Direccion)" +
                    "values ('" + ++i + "','" + wifi.Comuna + "','" + wifi.Barrio + "','" + wifi.NombreSitio +
                    "','" + wifi.Direccion + "')";
                Adapter.InsertCommand.ExecuteNonQuery();
                //Console.WriteLine(wifi.Ubicacion.Latitude.ToCharArray());
            }
            Connection.Close();
        }

        public void ActualizarHoteles()
        {
            var dataset = client.GetResource<Hotel>(DATASET_HOTELES);
            var datos = dataset.GetRows();
            Connection.Open();
            Adapter.DeleteCommand.CommandText = "delete * from Hoteles";
            Adapter.DeleteCommand.ExecuteNonQuery();
            int i = 0;
            foreach (Hotel hotel in datos)
            {
                Adapter.InsertCommand.CommandText = "insert into Hoteles (Id, Nombre, Direccion, Telefono, Propietario)" +
                    "values ('" + ++i + "','" + hotel.Nombre + "','" + hotel.Direccion + "','" + hotel.Telefono + "','" + hotel.Propietario + "')";
                Adapter.InsertCommand.ExecuteNonQuery();
            }
            Connection.Close();
        }

        public void Dispose()
        {
            if (client != null)
                client = null;
        }
    }
}
