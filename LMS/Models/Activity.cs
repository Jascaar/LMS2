using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LMS.Models
{
    public class Activity
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Activity Type")]
        public string ActivityType { get; set; }
        [StringLength(200, ErrorMessage = "The {0} must be between {1} and {2} characters long", MinimumLength = 1)]
        public string Description { get; set; }
        
        //Navigational property
        [Display(Name = "Module")]
        public virtual Module Module { get; set; }

        [Display(Name = "Activity Type")]
        public virtual ActivityType ActivityType_ { get; set; }  //????????
        [Required]
        [Display(Name = "Start date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }
        [Display(Name = "Duration (days)")]
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Only positive integers are valid")]
        public int DurationDays { get; set; }
        /*         protected DateTime endDate;
                [Display(Name = "End date")]
                [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
                public DateTime EndDate { get { return endDate; } set{endDate=StartDate.AddDays(DurationDays-1);} }
               protected String creationTime;
                [Display(Name = "Created")]
                [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
                public String CreationTime { get { return creationTime; } set {creationTime=DateTime.Now.ToShortTimeString(); } }*/
        [Display(Name = "Activity info")]
        [StringLength(5000, ErrorMessage = "The {0} must be between {1} and {2} characters long", MinimumLength = 1)]
        public string ActivityInfo { get; set; }

        /*        Appendices*/
}
}