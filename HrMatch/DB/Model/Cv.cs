using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrMatch.DB.Model
{
    public class Cv
    {
        public Cv()
        {
            this.Elans = new HashSet<Elan>();
        }
        public int Id { get; set; }
        public string CvName { get; set; }
        public string CvSurname { get; set; }
        public int CvAge { get; set; }
        public string CvSex { get; set; }
        public string CvWorkExperiment { get; set; }
        public string CvCity { get; set; }
        public string CvMinSalary { get; set; }
        public string ContactPhone { get; set; }
        public string EducationName { get; set; }
        public string WorkName { get; set; }
       
        public int Userid { get; set; }
      
     
       
        public User User { get; set; }
        //public Work MyWork { get; set; }
        public ICollection<Elan> Elans { get; set; }




    }
}
