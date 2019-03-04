using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentApplication.Models
{
    public class Course
    {
        [Display(Name = "Course ID")]
        public virtual int CourseId { get; set; }

        [Required(ErrorMessage = "You must enter a course title")]
        [StringLength(150, ErrorMessage = "Course Title must be less than 150 characters")]
        [Display(Name = "Course Title")]
        public virtual string Title { get; set; }

        public virtual string Description { get; set; }

        [Required(ErrorMessage = "You must Enter Number of credits")]
        [Range(1, 4, ErrorMessage = "Valid values are 1-4")]
        [Display(Name = "Number of credits")]
        public virtual decimal CourseCredits { get; set; }

    }
}