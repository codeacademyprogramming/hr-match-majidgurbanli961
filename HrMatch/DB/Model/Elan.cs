using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrMatch.DB.Model
{
    public class Elan
    {
        public Elan()
        {
            this.Cvs = new HashSet<Cv>();
        }
        public int Id { get; set; }
        public string ElanName { get; set; }
        public string ShirketName { get; set; }
        public string Workname { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
        public string Salary { get; set; }
        public int Age { get; set; }
        public string Experience { get; set; }
        public string Education { get; set; }
        public string Telephone { get; set; }
        public int Userid { get; set; }
     
      
        public User MyUser { get; set; }
        public ICollection<Cv> Cvs { get; set; }

    }
}
