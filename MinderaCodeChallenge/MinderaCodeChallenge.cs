using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinderaCodeChallenge
{
    public class MinderaCodeChallenge
    {
        static void Main(string[] args)
        {
            var arr1 = Group(new int[] { 16, 15, 14, 13, 34, 23, 24, 25, 26, 28, 45, 34, 23, 29, 12, 23, 45, 67, 23, 12, 34, 45, 23, 67, 23, 67 }, 3);
            PrintArrArr(arr1);
            var arr2 = Group(new int[] { 16, 15, 14, 13, 34, 23, 24, 25, 26, 28, 45, 34, 23, 29, 12, 23, 45, 67, 23, 12, 34, 45, 23, 67, 23, 670 }, 3);
            PrintArrArr(arr2);
            var arr3 = Group(new int[] { 160, 15, 14, 13, 34, 23, 24, 25, 26, 28, 45, 34, 23, 29, 12, 23, 45, 67, 23, 12, 34, 45, 23, 67, 23, 670 }, 4);
            PrintArrArr(arr3);
            var arr4 = Group(new int[] { 16, 15, 14, 13, 34, 23, 24, 25, 26, 28, 45, 34, 23, 29, 12, 23, 45, 67, 23, 12, 34, 45, 23, 67, 23, 67 }, 5);
            PrintArrArr(arr4);

            Console.ReadKey();
        }

        private static void PrintArrArr(int[][] matrix)
        {
            var sb = new StringBuilder();
            sb.Append(@"[");
            for (int i = 0; i < matrix.Length; i++)
            {
                Array.Sort(matrix[i]);
                sb.Append(@"[");
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    sb.Append(matrix[i][j]);
                    if(j!= matrix[i].Length - 1)
                    {
                        sb.Append(@", ");
                    }
                }
                sb.Append(@"]");
                if (i != matrix.Length-1)
                {
                    sb.Append($",{Environment.NewLine}");
                }
            }
            sb.Append(@"]");
            Console.WriteLine(sb.ToString());
            Console.WriteLine(Environment.NewLine);
        }

        public static int[][] Group(int[] values, int groups)
        {
            if(values == null || values.Length == 0 || groups < 1)
            {
                return new int[0][];
            }

            var k = (values.Length > groups) ? groups : values.Length;
            Array.Sort(values);

            var clusters = new List<Cluster>();
            var kClusters = new List<Cluster> { new Cluster(values.ElementAt(0)) };

            for (int i = 1; i < values.Count(); i++)
            {
                clusters.Add(new Cluster(values.ElementAt(i)));
            }

            while (kClusters.Count < k)
            {
                MoveNextBestClusterCandidate(kClusters, clusters);
            }

            MoveToClosestCluster(clusters, kClusters);
            while (RegroupClusters(kClusters)) ;


            int[][] groupsArray = new int[k][];
            for (int i = 0; i < kClusters.Count; i++)
            {
                groupsArray[i] = kClusters.ElementAt(i).Elements.ToArray();
            }

            return groupsArray;
        }

        private static bool RegroupClusters(List<Cluster> kClusters)
        {
            bool regrouped = false;
            RecalculateCentroids(kClusters);

            for (int i = 0; i < kClusters.Count; i++)
            {
                var outerCluster = kClusters.ElementAt(i);
                var outerElements = outerCluster.Elements;
                for (int j = 0; j < outerElements.Count; j++)
                {
                    var closestCluster = GetClosestClusterIndex(kClusters, outerElements.ElementAt(j));
                    if (closestCluster != i && closestCluster >= 0)
                    {
                        kClusters.ElementAt(closestCluster).Attach(outerElements.ElementAt(j));
                        outerElements.RemoveAt(j);
                        --j;
                        regrouped = true;
                    }
                }
            }

            return regrouped;
        }

        public static int GetClosestClusterIndex(List<Cluster> clusters, int value)
        {
            int index = -1;
            double distance = double.MaxValue;
            if(clusters == null)
            {
                return index;
            }
            for (int i = 0; i < clusters.Count; i++)
            {
                var d = clusters.ElementAt(i).GetCentroidDistance(value);
                if (d < distance)
                {
                    distance = d;
                    index = i;
                }
            }

            return index;
        }

        private static void RecalculateCentroids(List<Cluster> kClusters)
        {
            foreach (var c in kClusters)
            {
                c.RecalculateCentroid();
            }
        }

        private static void MoveToClosestCluster(List<Cluster> clusters, List<Cluster> kClusters)
        {
            while (clusters.Count > 0)
            {
                var currentCluster = clusters.ElementAt(0);
                var closestCluster = kClusters.ElementAt(0);
                var closestDistance = currentCluster.GetCentroidDistance(closestCluster);
                for (int j = 1; j < kClusters.Count; j++)
                {
                    var nextKCluster = kClusters.ElementAt(j);
                    var distance = currentCluster.GetCentroidDistance(nextKCluster);
                    if (distance < closestDistance)
                    {
                        closestDistance = distance;
                        closestCluster = nextKCluster;
                    }
                }
                closestCluster.Attach(currentCluster);
                clusters.RemoveAt(0);
            }
        }

        private static void MoveNextBestClusterCandidate(List<Cluster> kClusters, List<Cluster> clusters)
        {
            int bestIndex = -1;
            double maxDistance = -1;

            for (int i = 0; i < clusters.Count; i++)
            {
                var current = clusters.ElementAt(i);
                var tmpMaxDistance = kClusters.ElementAt(0).GetCentroidDistance(current);
                for (int j = 1; j < kClusters.Count; j++)
                {
                    var distanceToKClusterJ = kClusters.ElementAt(j).GetCentroidDistance(current);
                    if (tmpMaxDistance > distanceToKClusterJ)
                    {
                        tmpMaxDistance = distanceToKClusterJ;
                    }
                }

                if (maxDistance < tmpMaxDistance)
                {
                    maxDistance = tmpMaxDistance;
                    bestIndex = i;
                }
            }

            if (bestIndex != -1)
            {
                kClusters.Add(clusters.ElementAt(bestIndex));
                clusters.RemoveAt(bestIndex);
            }
        }
    }

    public class Cluster
    {
        public List<int> Elements { get; }
        public double Centroid { get; private set; }

        public Cluster(int element)
        {
            Centroid = (double)element;
            Elements = new List<int> { element };
        }

        public void Attach(Cluster c)
        {
            Elements.AddRange(c.Elements);
        }

        public void Attach(int element)
        {
            Elements.Add(element);
        }

        public void RecalculateCentroid()
        {
            var sum = 0;
            foreach (var item in Elements)
            {
                sum += item;
            }
            Centroid = sum / (double)Elements.Count;
        }

        public double GetCentroidDistance(Cluster c) => Math.Abs(Centroid - c.Centroid);
        public double GetCentroidDistance(int element) => Math.Abs(Centroid - element);

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"[ {Elements.ElementAt(0)}");
            for (int i = 1; i < Elements.Count; i++)
            {
                sb.Append($", {Elements.ElementAt(i)}");
            }
            sb.Append(@" ]");
            return sb.ToString();
        }
    }
}
