using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentApplication.Models
{
    public class Student
    {
        [Display(Name = "Student ID")]
        public virtual int StudentId { get; set; }

        [Required(ErrorMessage = "Last Name is a required field")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Last Name must be between 3 and 50 characters")]
        [Display(Name = "Last Name")]
        public virtual string LastName { get; set; }


        [Required(ErrorMessage = "First Name is a required field")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Last Name must be between 3 and 50 characters")]
        [Display(Name = "First Name")]
        public virtual string FirstName { get; set; }
    }
}