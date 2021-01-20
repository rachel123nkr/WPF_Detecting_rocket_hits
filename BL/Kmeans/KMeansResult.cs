using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BL.Kmeans
{
    public class KMeansResult
    {
        BE.Coordinate realFall;
        BE.Coordinate estimateFall;
        double distance;

        public KMeansResult()
        {
        
        }
        public KMeansResult(Coordinate realF, Coordinate estimateF, double dis)
        {
            realFall = realF;
            estimateFall = estimateF;
            distance = dis;
        }
    }
}
