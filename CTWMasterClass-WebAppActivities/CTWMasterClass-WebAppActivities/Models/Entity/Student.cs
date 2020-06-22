using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CTWMasterClass_WebAppActivities.Models.Entity
{
    public class Student:IEntity
    {
        public int Id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
    }
}