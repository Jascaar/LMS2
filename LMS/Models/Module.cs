using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LMS.Models
{
    public class Module
    {
        public int Id { get; set; }
        [StringLength(50, ErrorMessage = "The {0} must be between {1} and {2} characters long", MinimumLength = 1)]
        [Display(Name = "Module name")]
        [Required]
        public string ModuleName
        {
            get
            { return moduleName; }
            set
            {
               moduleName =  InitialCapital(value);
            }
        }
        protected string moduleName { get; set; }

        [StringLength(200, ErrorMessage = "The {0} must be between {1} and {2} characters long", MinimumLength = 1)]
        [Required]
        public string Description { get; set; }
        
        //Navigational property
        [Display(Name = "Start Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required]
        public DateTime StartDate { get; set; }
        [Display(Name = "Duration (days)")]
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Only positive integers are valid")]
        public int DurationDays { get; set; }
/*        protected DateTime endDate;
        [Display(Name = "End date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get { return endDate; } set { endDate = StartDate.AddDays(DurationDays - 1); } }
        protected String creationTime;
        [Display(Name = "Created")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public String CreationTime { get { return creationTime; } set { creationTime = DateTime.Now.ToShortTimeString(); } }    */
        [StringLength(5000, ErrorMessage = "The {0} must be between {1} and {2} characters long", MinimumLength = 1)]
        [Display(Name = "Module Info")]
        public string ModuleInfo { get; set; }
        [Display(Name = "Activities")]
        //navigational property
        public virtual ICollection<Course> Course { get; set; }
        /*        Appendices*/


        //var lägger sådana här så att flera sidor når dem??? fattar inte varför det inte fungerar enkelt
        public string InitialCapital(string value)
    {
        if (value == null | value.Trim().Length == 0) value = "";
        if (value.Trim().Length > 1)
        value = value.Trim().Substring(1, 1).ToUpper() + value.Trim().Substring(1, value.Length - 1).ToLower();
                else
                value = value.Trim().ToUpper();
        return value;
    }

    }

}