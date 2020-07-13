﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrMatch.DB.Model
{
    public class User
    {
        
        
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int WhichUser { get; set; }
        
        public ICollection<Elan> Elans { get; set; }
        public ICollection<Cv> Cvs  { get; set; }   





    }
}
