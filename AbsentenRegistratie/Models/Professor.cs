using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AbsentenRegistratie.Models;

namespace AbsentenRegistratie.Models
{
    public class Professor
    {
        private int id;
        private string name;
        private string email;
        private string password;
        public List<Subject> subjects;

    }
}