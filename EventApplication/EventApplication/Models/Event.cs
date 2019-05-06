using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EventApplication.Models
{
    public class Event : IValidatableObject
    {
        [Display(Name = "Event Title")]
        [Required]
        [StringLength(50, ErrorMessage = " Error Title should not exceed 50 characters")]
        public virtual string Title { get; set; }

        public virtual int EventId { get; set; }

        [Display(Name = "Event Description")]
        [StringLength(150, ErrorMessage = "Error Description should not exceed 150 characters")]
        public virtual string Description { get; set; }


        [Display(Name = "Event Start Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        [Required]
        public virtual DateTime StartDate { get; set; }


        [Display(Name = "Event End Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        [Required]
        public virtual DateTime EndDate { get; set; }

        [Required]
        public virtual string City { get; set; }

        [Required]
        public virtual string State { get; set; }

        public virtual string EventTypeId { get; set; }

        public virtual EventType EventType { get; set; }

        [Display(Name = "Organizer Name")]
        [Required]
        public virtual string OrganizerName { get; set; }

        [Display(Name = "Organizer Contact Info")]
        public virtual string OrganizerContactInfo { get; set; }

        [MinLength(1, ErrorMessage = "Maximum Tickets cannot be 0")]
        [Display(Name = "Max Tickets")]
        [Required]
        public virtual string MaxTickets { get; set; }

        [MinLength(1, ErrorMessage = "Available Tickets cannot be 0")]
        [Display(Name = "Available Tickets")]
        [Required]
        public virtual string AvailableTickets { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validation)
        {

            if ((StartDate.Date >= EndDate.Date))
            {
                yield return (new ValidationResult("Event End Date cannot be less than Event Start Date", new[] { "StartDate", "EndDate" }));
            }
        }
    }
}