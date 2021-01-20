using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FactoryDal
    {
        static Idal idal = null;

        public static Idal get_dal()
        {
            if (idal == null)
            {
                var db = new ProjectContext();
                idal = new Dal_imp();
            }
            return idal;   
        }
    }
}
