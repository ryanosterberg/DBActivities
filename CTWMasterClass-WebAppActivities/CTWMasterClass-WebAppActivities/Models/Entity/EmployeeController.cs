using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CTWMasterClass_WebAppActivities.Models.Entity
{
    public class Employee : IEntity
    {
        public int Id { get; set; }
        public string name { get; set; }
        public DateTime hireDate { get; set; }
    }
}