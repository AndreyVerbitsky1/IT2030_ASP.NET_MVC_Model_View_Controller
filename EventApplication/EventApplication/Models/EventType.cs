using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EventApplication.Models
{
    public class EventType
    {
        public virtual int EventTypeId { get; set; }

        [StringLength(50, ErrorMessage = "Error Type should not exceed 50 characters")]
        public virtual string Type { get; set; }
    }
}