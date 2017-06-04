using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinderaCodeChallenge
{
    public class ChallengeClusterSolution : IMinderaCodeChallenge
    {
        int[] _values;
        int _groups;
        public int[][] Groups { get; private set; }

        public int[][] Group(int[] values, int groups)
        {
            if (values == null || values.Length == 0 || groups < 1)
            {
                Groups = new int[0][];
                return Groups;
            }

            _values = values;
            _groups = groups;

            var k = (_values.Length > _groups) ? _groups : _values.Length;
            Array.Sort(_values);

            var clusters = new List<Cluster>();
            var kClusters = new List<Cluster> { new Cluster(_values.ElementAt(0)) };

            for (int i = 1; i < _values.Count(); i++)
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

            Groups = groupsArray;
            return Groups;
        }

        private bool RegroupClusters(List<Cluster> kClusters)
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

        public int GetClosestClusterIndex(List<Cluster> clusters, int value)
        {
            int index = -1;
            double distance = double.MaxValue;
            if (clusters == null)
            {
                return index;
            }
            for (int i = 0; i < clusters.Count; i++)
            {
                if(clusters.ElementAt(i) == null)
                {
                    continue;
                }
                var d = clusters.ElementAt(i).GetCentroidDistance(value);
                if (d < distance)
                {
                    distance = d;
                    index = i;
                }
            }

            return index;
        }

        private void RecalculateCentroids(List<Cluster> kClusters)
        {
            foreach (var c in kClusters)
            {
                c.RecalculateCentroid();
            }
        }

        private void MoveToClosestCluster(List<Cluster> clusters, List<Cluster> kClusters)
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

        private void MoveNextBestClusterCandidate(List<Cluster> kClusters, List<Cluster> clusters)
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
            if (Elements.Count == 0)
            {
                Centroid = double.MinValue;
                return;
            }
            var sum = 0;
            foreach (var item in Elements)
            {
                sum += item;
            }
            Centroid = sum / (double)Elements.Count;
        }

        public double GetCentroidDistance(Cluster c) => Distance(Centroid, c.Centroid);

        public double GetCentroidDistance(int element) => Distance(Centroid, element);

        double Distance(double i, double j)
        {
            if ((i >= 0 && j >= 0) || (i <= 0 && j <= 0))
            {
                return Math.Abs(i - j);
            }
            return Math.Abs(i + j);
        }

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
