using System;
using System.ComponentModel.DataAnnotations;

namespace HelperAppDL.Models
{
    public class Advertisement
    {
        [Required]
        [MaxLength(15)]
        public string AdId { get; set; }

        [Required]
        [MaxLength(25)]
        public string Category { get; set; }

        [MaxLength(25)]
        public string SubCategory { get; set; }

        [Required]
        [MaxLength(50)]
        public string AdTitle { get; set; }

        [Required]
        [MaxLength(500)]
        public string AdDescription { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string AdPicture { get; set; }

        public HelperUser AdOwner { get; set; }

    }
}
