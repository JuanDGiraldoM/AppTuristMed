using System;
using System.Device.Location;

namespace AppTuristMed.Clases
{
    class Ubicacion
    {
        public double Latitud { get; set; }
        public double Longitud { get; set; }

        public Ubicacion(double latitud, double longitud)
        {
            Latitud = latitud;
            Longitud = longitud;
        }

        public Ubicacion(string ubicacion)
        {
            string latitud = "", longitud = "";
            string[] campos = ubicacion.Split(',');

            char[] cadena1 = campos[0].ToCharArray();
            char[] cadena2 = campos[1].ToCharArray();

            for (int i = 1; i < cadena1.Length - 1; i++)
                latitud += cadena1[i];
            for (int i = 1; i < cadena2.Length - 2; i++)
                longitud += cadena2[i];

            Latitud = double.Parse(latitud);
            Longitud = double.Parse(longitud);
        }

        public static Ubicacion ObtenerUbicacion()
        {
            GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();
            watcher.TryStart(false, TimeSpan.FromMilliseconds(1000));
            GeoCoordinate coord = watcher.Position.Location;


            if (coord.IsUnknown != true)
                return new Ubicacion(coord.Latitude, coord.Longitude);

            else
                return null;
        }

        public double CalcularDistacia(Ubicacion coord1)
        {
            double deg2rad = Math.PI / 180;
            double radius = 6378.137;

            double lat1 = Latitud * deg2rad;
            double lat2 = coord1.Latitud * deg2rad;
            double lon1 = Longitud * deg2rad;
            double lon2 = coord1.Longitud * deg2rad;
            double dlon = lon1 - lon2;

            return Math.Acos(Math.Sin(lat1) * Math.Sin(lat2) + Math.Cos(lat1) * Math.Cos(lat2) * Math.Cos(dlon)) * radius;
        }
    }
}
