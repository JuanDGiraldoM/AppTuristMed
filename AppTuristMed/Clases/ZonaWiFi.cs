using System;

namespace AppTuristMed.Clases
{
    class ZonaWiFi : Registro
    {
        public string NombreComuna { get; set; }
        public string Barrio { get; set; }
        public string NombreSitio { get; set; }

        public ZonaWiFi(string NombreComuna, string Barrio, string NombreSitio, string Direccion, string Punto)
        {
            this.NombreComuna = NombreComuna;
            this.Barrio = Barrio;
            this.NombreSitio = NombreSitio;
            this.Direccion = Direccion;
            Ubicacion = new Ubicacion(Punto);
        }
    }
}
