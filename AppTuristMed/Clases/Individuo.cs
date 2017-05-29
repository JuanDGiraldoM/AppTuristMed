using System;
using System.Collections;

namespace AppTuristMed.Clases
{
    class Individuo
    {
        public int[] Vector { get; set; }
        public double Cohesion { get; set; }
        public Cluster[] Clusters { get; set; }

        public Individuo(ArrayList registros, int num_clusteres)
        {
            Random n = new Random();
            Vector = new int[registros.Count];
            for (int j = 0; j < Vector.Length; j++)
                Vector[j] = n.Next(num_clusteres) + 1;

            Clusters = new Cluster[num_clusteres];
            CalcularCohesion(registros);
        }

        public void CalcularCohesion(ArrayList registros)
        {
            for (int i = 1; i <= Clusters.Length; i++)
            {
                ArrayList datos = new ArrayList();
                foreach (int id_cluster in Vector)
                    if (id_cluster == i)
                        datos.Add(registros[i]);

                Cluster cluster = new Cluster(datos);
                Clusters[i - 1] = cluster;
                Cohesion += cluster.Cohesion;
            }
        }
    }
}
