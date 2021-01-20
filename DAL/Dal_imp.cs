using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public class Dal_imp : Idal
    {
        
        public async void AddFall(Fall newFall)
        {
            //if (GetFall(newFall.FallId) != null)
            //    throw new Exception("The fall is already exist");
           // else
                using (var db = new ProjectContext())
                {
                     db.Falls.Add(newFall);
                    await db.SaveChangesAsync();
                }

        }

        public async void AddReportFall(ReportFall newReport)
        {
            if (GetReport(newReport.DateRep, newReport.NameReporter) != null)
                throw new Exception("The fall is already exist");
            else
            {
                using (var db = new ProjectContext())
                {
                    db.Reports.Add(newReport);
                    await db.SaveChangesAsync();

                }
              }
        }

        public void DelFall(Fall newFall)
        {
            if (GetFall(newFall.FallId) == null)
                throw new Exception("The fall is not exist");
           // else
               // DataSource.Remove(newFall);
        }

        public void DelReportFall(ReportFall newReport)
        {
            if (GetReport(newReport.DateRep, newReport.NameReporter) == null)
                throw new Exception("The fall is not exist");
           //else
             //   DataSource.Remove(newFall);
        }

        public  List<Fall> ListFalls()
        {
            List<Fall> result = new List<Fall>();
            using (var db = new ProjectContext())
            {
                var query = from elem in db.Falls
                            select elem;
                foreach (var item in query)
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public Fall GetFall(int id)
        {
            using (var db = new ProjectContext())
            {
                var result = db.Falls.SingleOrDefault(f1 => f1.FallId == id);

                if (result == null)
                {
                    return null;

                }
                else
                {
                    return result;
                }
            }
        }

        public ReportFall GetReport(DateTime dateRep, string name)
        {
            using (var db = new ProjectContext())
            {
                var result = db.Reports.SingleOrDefault(r1 => r1.DateRep == dateRep && r1.NameReporter == name);

                if (result == null)
                {
                    return null;

                }
                else
                {
                    return result;
                }
            }
        }

        public List<ReportFall> ListReportFalls()
        {
            List<ReportFall> result = new List<ReportFall>();
            using (var db = new ProjectContext())
            {
                var query = from elem in db.Reports
                            select elem;
                foreach (var item in query)
                {
                    result.Add(item);
                }
            }
            return result;

        }

        public async void UpdateFall(Fall newFall)
        {
            using (var db = new ProjectContext())
            {
                var result = db.Falls.SingleOrDefault(f1 => f1.FallId == newFall.FallId);

                if (result == null)
                {
                    throw new Exception("Fall doesnt exist");

                }
                else
                {
                    result = newFall;
                    await db.SaveChangesAsync();
                }
            }

        }

        public async void UpdateReportFall(ReportFall newReport)
        {
            using (var db = new ProjectContext())
            {
                var result = db.Reports.SingleOrDefault(r1 => r1.DateRep == newReport.DateRep && r1.NameReporter== newReport.NameReporter);

                if (result == null)
                {
                    throw new Exception("Report Fall doesnt exist");

                }
                else
                {
                    result = newReport;
                    await db.SaveChangesAsync();
                }
            }
        }

        public Coordinate GetCoordinate(string city, string Address)
        {
            return new Geocoder().Geocode(city, Address);
        }
        public Coordinate GetImageCoordinate(string path)
        {
            return new Geocoder().getImageCoordinate(path);
        }

        public double GetDistanceBetweenPoints(Coordinate coo1, Coordinate coo2)
        {
            return new Geocoder().GetDistanceBetweenPoints(coo1, coo2);
        }

        //public ReportFall[] GetReportBetweenTime(DateTime dateRep)
        //{
        //    using (var db = new ProjectContext())
        //    {
        //        //var query = from elem in db.Reports
        //        //where (elem.DateRep + new TimeSpan(20, 10, 0)) < dateRep && (dateRep-new TimeSpan(20, 10, 0)) < elem.DateRep
        //        //          select elem;

        //        //var result = query.ToArray<ReportFall>(); //db.Reports.ToArray<ReportFall>();//(r1 => r1.DateRep == dateRep && r1.NameReporter == name);

        //        var now_10Minute = dateRep - new TimeSpan(0, 10, 0);
        //        Func<ReportFall,int ,bool> fun = (x,y) => (x.DateRep <dateRep  )&& (now_10Minute<x.DateRep) ;
        //        var result = db.Reports.Where<ReportFall>(fun);

        //        if (result == null)
        //        {
        //            return null;
        //        }
        //        else
        //        {
        //            var x=result.ToArray<ReportFall>();
        //            return x;
        //        }
        //    }
        //}


        public ReportFall[] GetReportBetweenTime(DateTime dateFall)
        {
            using (var db = new ProjectContext())
            {
                //var query = from elem in db.Reports
                //where (elem.DateRep + new TimeSpan(20, 10, 0)) < dateRep && (dateRep-new TimeSpan(20, 10, 0)) < elem.DateRep
                //          select elem;

                //var result = query.ToArray<ReportFall>(); //db.Reports.ToArray<ReportFall>();//(r1 => r1.DateRep == dateRep && r1.NameReporter == name);

                var now_10Minute = dateFall + new TimeSpan(0, 10, 0);
                Func<ReportFall, int, bool> fun = (x, y) => (x.DateRep < now_10Minute) && (dateFall < x.DateRep);
                var result = db.Reports.Where<ReportFall>(fun);

                if (result == null)
                {
                    return null;
                }
                else
                {
                    var x = result.ToArray<ReportFall>();
                    return x;
                }
            }
        }


        public async void AddUser(User user)
        {
            using (var db = new ProjectContext())
            {
                db.Users.Add(user);
                await db.SaveChangesAsync();
            }
        }

        public User GetUser(string email, string password)
        {
            using (var db = new ProjectContext())
            {
                var result = db.Users.SingleOrDefault(r1 => r1.EmailUser == email && r1.PasswordUser == password);

                if (result == null)
                {
                    return null;
                }
                else
                {
                    return result;
                }
            }
        }
    }
}
