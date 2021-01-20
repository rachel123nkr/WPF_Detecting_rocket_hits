using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public interface Idal
    {
        #region Report
        void AddReportFall(ReportFall newReport);
        void UpdateReportFall(ReportFall newReport);
        void DelReportFall(ReportFall newReport);
        ReportFall GetReport(DateTime dateRep, String name);
        List<ReportFall> ListReportFalls();
        #endregion Report

        #region Fall
        void AddFall(Fall newFall);
        void UpdateFall(Fall newFall);
        void DelFall(Fall newFall);
        Fall GetFall(int id);
        List<Fall> ListFalls();
        #endregion Fall

        #region Coordinate
        Coordinate GetCoordinate(String city, String Address);
        Coordinate GetImageCoordinate(string path);
        double GetDistanceBetweenPoints(Coordinate coo1, Coordinate coo2);
        ReportFall[] GetReportBetweenTime(DateTime dateRep);

        #endregion Coordinate

        #region User
        void AddUser(User user);
        User GetUser(string email, string password);

        #endregion User



    }
}
