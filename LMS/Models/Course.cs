using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LMS.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Course Name")]
        public string CourseName { get; set; }

        [StringLength(200, ErrorMessage = "The description can at most be 200 characters long")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Start Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Only positive integers are valid")]
        [Display(Name = "Duration (days)")]
        public int DurationDays { get; set; }
/*        protected DateTime endDate;
                [Display(Name = "End date")]
                public DateTime EndDate { get { return endDate; } set { endDate = StartDate.AddDays(DurationDays - 1).Date; } }
                      protected String creationTime;
                      [Display(Name = "Created")]
                      [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
                      public String CreationTime { get { return creationTime; } set { creationTime = (string)DateTime.Now.ToShortTimeString(); } }*/
        [Display(Name = "Urgent information")]
        public string UrgentInfo { get; set; }
        //Appendices/Documents

        public virtual ICollection<ApplicationUser> AttendingStudents { get; set; }
    }
}