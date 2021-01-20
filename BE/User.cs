using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string EmailUser { get; set; }
        public string PasswordUser { get; set; }
        public bool CellCenter { get; set; }
        public bool Analyst { get; set; }
        public User()
        {
            EmailUser = "";
            PasswordUser = "";
            CellCenter = false;
            Analyst = false;
        }
        public User(string EmailUser_ ,string PasswordUser_ ,bool CellCenter_ ,bool Analyst_ )
        {
            this.EmailUser = EmailUser_;
            this.PasswordUser = PasswordUser_;
            this.CellCenter = CellCenter_;
            this.Analyst = Analyst_;
        }

    }
}
