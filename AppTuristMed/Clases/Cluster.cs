using System;
using System.Collections;

namespace AppTuristMed.Clases
{
    class Cluster
    {
        public ArrayList Registros { get; set; }
        public Ubicacion Centro { get; set; }
        public double Cohesion { get; set; }

        public Cluster (ArrayList datos)
        {
            Registros = datos;
            CalcularCentro();
            CalcularCohesion();
        }

        private void CalcularCentro()
        {
            double latitud = 0;
            double longitud = 0;
            foreach(Registro dato in Registros)
            {
                latitud += dato.Ubicacion.Latitud;
                longitud += dato.Ubicacion.Longitud;
            }
            latitud /= Registros.Count;
            longitud /= Registros.Count;

            Centro = new Ubicacion(latitud, longitud);
        }

        private void CalcularCohesion()
        {
            double distancia = 0;
            foreach (Registro dato in Registros)
                distancia += dato.Ubicacion.CalcularDistacia(Centro);
            Cohesion = distancia;
        }
    }
}
