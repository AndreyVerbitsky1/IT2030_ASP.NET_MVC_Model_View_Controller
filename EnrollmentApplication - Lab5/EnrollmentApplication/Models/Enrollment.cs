using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentApplication.Models
{
    public class Enrollment
    {
        [Display(Name= "Enrollment ID")]
        public virtual int EnrollmentId { get; set; }

        [Display(Name = "Student ID")]
        public virtual int StudentId { get; set; }

        [Display(Name = "Course ID")]
        public virtual int CourseId { get; set; }

        [Required(ErrorMessage = "You Must Enter a Grade")]
        [RegularExpression(@"[A-F]", ErrorMessage = "letter grades A-F")]
        public virtual string Grade { get; set; }
        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }
        public virtual string EnrollmentImgUrl { get; set; }
        public virtual bool IsActive { get; set; }

        [Required(ErrorMessage = "You must enter Assigned Campus")]
        [Display(Name = "Assigned Campus")]
        public virtual string AssignedCampus { get; set; }

        [Required(ErrorMessage = "You must Enter the semester Enrolled")]
        [Display(Name = "Enrolled in Semester")]
        public virtual string EnrollmentSemester { get; set; }

        [Required(ErrorMessage = "You Must enter Enrollment year")]
        [Range(2018, 3018)]
        public virtual int EnrollmentYear { get; set; }
    }
}