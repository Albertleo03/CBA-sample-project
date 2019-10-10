using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServiceLayer.DBContext
{
    [Table("tblEmployee")]
    public class Employee
    {
        [Key]
        public int id { get; set; }
        public string domainname { get; set; }
        public string Teamname { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public int Lanid { get; set; }
    }
}