using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace sumedStudyGroup.Models
{
	public class MyClass
	{
        [Display(Name = "Student Number")]
        public string StudentNumber { get; set; } 

        [Display(Name ="Name")]
        public string Name { get; set; }

        [Display(Name ="Surname")]
        public string Surname { get; set; }

        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

    }
}