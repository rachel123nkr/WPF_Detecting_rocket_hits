using BE;
using BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL.Model
{
    public class Model
    {
        public Model()
        {
            CurFall = new Fall();
            CurRepFall = new ReportFall();
            CurUser = new User();
            Bl = BL.FactoryBL.GetBL();
            CurKmeans = Bl.GetKMeans();
            
        }

        private ReportFall curRepFall;

        public ReportFall CurRepFall
        {
            get { return curRepFall; }
            set
            {
                curRepFall = value;

            }
        }
        public Fall CurFall { get; set; }
        public User CurUser { get; set; }

        public K_means CurKmeans { get; set; }


        public IBL Bl { get; set; }
    }
}
