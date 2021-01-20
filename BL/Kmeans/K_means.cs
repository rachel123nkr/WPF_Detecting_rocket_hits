using Accord.MachineLearning;
using BE;
using BL.Kmeans;
using Microsoft.ML;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class K_means
    {
        public K_means()
        {

        }
        
       
        public Coordinate[] returnAvgPerGroup(double[][] data, double[] weight, int numK)
        {
            Accord.Math.Random.Generator.Seed = 0;
            // Create a new K-Means algorithm
            KMeans kmeans = new KMeans(k: numK);
            // Compute and retrieve the data centroids
            var clusters = kmeans.Learn(data, weight);
            // var clusters2=kmeans.Compute(observations,new double[2,7,3,4,7,3])
            // Use the centroids to parition all the data
            double[][] res1 = clusters.Centroids;
            Coordinate[] res = new Coordinate[res1.Length];
            for (int i = 0; i < res1.Length; i++)
            {
                //Console.WriteLine(res1[0][0]);
                //Console.WriteLine(res1[0][1]);
                res[i] =new Coordinate(res1[i][0],res1[i][0]);
            }
            return res;
        }


        
        public int[] returnPointPerGroup(double[][] data, double[] weight, int numK)
        {
            Accord.Math.Random.Generator.Seed = 0;
            // Create a new K-Means algorithm
            KMeans kmeans = new KMeans(k: numK);
            // Compute and retrieve the data centroids
            var clusters = kmeans.Learn(data, weight);
            // Use the centroids to parition all the data
            int[] labels = clusters.Decide(data);
            return labels;
        }


      
        /// <summary>
        /// 
        /// </summary>
        /// <param name="coors">array of reports</param>
        /// <returns>the K means Coordinate</returns>
        public Coordinate[] returnAvgPerGroupFromRep(ReportFall[] coors)
        {
            if (coors.Length == 0 || coors == null) return new Coordinate[0];
            int numK = 0;
            double[][] data = new double[coors.Length][];
            double[] weight = new double[coors.Length];
            for (int i = 0; i < coors.Length; i++)
            {
                data[i] = new double[] { coors[i].CoordinateR.Latitude, coors[i].CoordinateR.Longitude };
                weight[i] = coors[i].Intensity;
                numK += coors[i].BoomsN;
            }

            //numK = numK / coors.Length;
            numK = 1;//////////////////////////////////////////
            Accord.Math.Random.Generator.Seed = 0;
            // Create a new K-Means algorithm
            KMeans kmeans = new KMeans(k: numK);
            // Compute and retrieve the data centroids
            var clusters = kmeans.Learn(data, weight);
            // var clusters2=kmeans.Compute(observations,new double[2,7,3,4,7,3])
            // Use the centroids to parition all the data
            double[][] res1 = clusters.Centroids;
            Coordinate[] res = new Coordinate[res1.Length];
            for (int i = 0; i < res1.Length; i++)
            {
                //Console.WriteLine(res1[0][0]);
                //Console.WriteLine(res1[0][1]);
                res[i] = new Coordinate(res1[i][0], res1[i][1]);
            }
            return res;
        }

    }
}
