using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentApplication.Models
{
    public class Student : IValidatableObject
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

        public virtual string Address1 { get; set; }
        public virtual string Address2 { get; set; }
        public virtual string City { get; set; }
        public virtual string Zipcode { get; set; }
        public virtual string State { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
         // Address 2 must be different than Address1
            if (Address2 == Address2)
            {
                yield return (new ValidationResult("Address2 cannot be the same as Address1"));
            }

            //State Must be 2 digits long
            if (State.Length < 2 || State.Length > 2)
            {
                yield return (new ValidationResult("Enter a 2 digit State code"));
            }

            //Zipcode must be 5 digits long
            if (Zipcode.Length < 5 || Zipcode.Length > 5)
            {
                yield return (new ValidationResult("Enter a 5 digit Zipcode"));
            }
            throw new NotImplementedException();
        }
    }

}