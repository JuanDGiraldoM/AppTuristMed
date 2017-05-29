using System;
using System.Collections;

namespace AppTuristMed.Clases
{
    class AlgoritmoGenetico
    {
        public double Crossover { get; set; }
        public double Mutation { get; set; }
        public int NumClusteres { get; set; }
        public int NumIndividuos { get; set; }
        public int NumGeneraciones { get; set; }

        public AlgoritmoGenetico(double crossover, double mutation, int num_clusteres, int num_individuos, int num_generaciones)
        {
            Crossover = crossover;
            Mutation = mutation;
            NumClusteres = num_clusteres;
            NumIndividuos = num_individuos;
            NumGeneraciones = num_generaciones;
        }

        public Cluster[] Clustering(ArrayList registros, Ubicacion ubicacion)
        {
            Random n = new Random();
            Individuo[] padres = new Individuo[2];
            Individuo[] generacion = new Individuo[NumIndividuos];
            
            for (int i = 0; i < NumIndividuos; i++)
                generacion[i] = new Individuo(registros, NumClusteres);
                        
            for (int i = 0; i < NumGeneraciones; i++)
            {
                padres = FindBestFitness(generacion);
                
                if(n.NextDouble() <= Crossover)
                    DoCrossover(padres, registros);

                if (n.NextDouble() <= Mutation)
                    DoMutate(padres, registros);

                int[] peores = FindWorstFitness(generacion);

                Individuo[] aptos = { padres[0], padres[1], generacion[peores[0]], generacion[peores[1]] };
                aptos = FindBestFitness(aptos);

                generacion[peores[0]] = aptos[0];
                generacion[peores[1]] = aptos[1];
            }
            
            return FindBestFitness(generacion)[0].Clusters;
        }

        private void DoCrossover(Individuo [] padres, ArrayList registros)
        {
            Random n = new Random();
            int cut = n.Next(1, padres[0].Vector.Length);
            for(int i=cut; i < padres[0].Vector.Length; i++)
            {
                int id_cluster = padres[0].Vector[i];
                padres[0].Vector[i] = padres[1].Vector[i];
                padres[1].Vector[i] = id_cluster;
            }
            padres[0].CalcularCohesion(registros);
            padres[1].CalcularCohesion(registros);
        }

        private void DoMutate(Individuo[] padres, ArrayList registros)
        {
            Random n = new Random();
            for (int i=0; i < padres[0].Vector.Length; i++)
            {
               if(n.Next(2) == 1)
                {
                    padres[0].Vector[i] = n.Next(1, NumClusteres);
                    padres[1].Vector[i] = n.Next(1, NumClusteres);
                }
            }
            padres[0].CalcularCohesion(registros);
            padres[1].CalcularCohesion(registros);
        }

        public Individuo[] FindBestFitness(Individuo[] generacion)
        {
            Individuo[] bestfitness = new Individuo[2];
            if (generacion[0].Cohesion < generacion[1].Cohesion)
            {
                bestfitness[0] = generacion[0];
                bestfitness[1] = generacion[1];
            }
            else
            {
                bestfitness[0] = generacion[1];
                bestfitness[1] = generacion[0];
            }
            
            for (int j = 2; j < generacion.Length; j++)
            {
                if (generacion[j].Cohesion < bestfitness[0].Cohesion)
                    bestfitness[0] = generacion[j];
                else if (generacion[j].Cohesion < bestfitness[1].Cohesion)
                    bestfitness[1] = generacion[j];
            }
            return bestfitness;
        }

        public int[] FindWorstFitness(Individuo[] generacion)
        {
            int[] posiciones = new int[2];
            if (generacion[0].Cohesion > generacion[1].Cohesion)
            {
                posiciones[0] = 0;
                posiciones[1] = 1;
            }
            else
            {
                posiciones[0] = 1;
                posiciones[1] = 0;
            }

            for (int j = 2; j < generacion.Length; j++)
            {
                if (generacion[j].Cohesion > generacion[posiciones[0]].Cohesion)
                    posiciones[0] = j;
                else if (generacion[j].Cohesion > generacion[posiciones[1]].Cohesion)
                    posiciones[1] = j;
            }
            return posiciones;
        }
    }
}
