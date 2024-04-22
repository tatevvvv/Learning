using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class Dijkstra
    {

        public static void dijkstra(int[][] graph, int source)
        {
            int count = graph.Length;
            bool[] visitedVertex = new bool[count];
            int[] distance = new int[count];
            for (int i = 0; i < count; i++)
            {
                visitedVertex[i] = false;
                distance[i] = int.MaxValue;
            }

            // Distance of self loop is zero
            distance[source] = 0;
            for (int i = 0; i < count; i++)
            {

                // Update the distance between neighbouring vertex and source vertex
                int u = findMinDistance(distance, visitedVertex);
                visitedVertex[u] = true;

                // Update all the neighbouring vertex distances
                for (int v = 0; v < count; v++)
                {
                    if (!visitedVertex[v] && graph[u][v] != 0 && (distance[u] + graph[u][v] < distance[v]))
                    {
                        distance[v] = distance[u] + graph[u][v];
                    }
                }
            }
            //for (int i = 0; i < distance.length; i++)
            //{
            //    System.out.println(String.format("Distance from %s to %s is %s", source, i, distance[i]));
            //}

        }

        // Finding the minimum distance
        private static int findMinDistance(int[] distance, bool[] visitedVertex)
        {
            // int minDistance = Integer.MAX_VALUE;
            int minDistanceVertex = -1;

            //for (int i = 0; i < distance.length; i++)
            //{
            //    if (!visitedVertex[i] && distance[i] < minDistance)
            //    {
            //        minDistance = distance[i];
            //        minDistanceVertex = i;
            //    }
            //}
            return minDistanceVertex;
        }

        public static void main(String[] args)
        {
            Dijkstra T = new Dijkstra();
            // T.dijkstra(graph, 0);
        }
    }
}
