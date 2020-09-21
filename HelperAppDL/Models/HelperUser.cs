using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HelperAppDL.Models
{
    public class HelperUser
    {
        [Required]
        [MinLength(10)]
        [MaxLength(10)]
        public string HelperUserId { get; set; }

        [Required]
        [MaxLength(20)]
        public string HelperUserName { get; set; }

        [Required]
        [MaxLength(15)]
        [RegularExpression(@"^([0]|\+91[\-\s]?)?[789]\d{9}$", ErrorMessage = "Mobile number is not valid")]
        public string MobileNumber { get; set; }

        [MaxLength(15)]
        [RegularExpression(@"^([0]|\+91[\-\s]?)?[789]\d{9}$", ErrorMessage = "Alternate mobile number is not valid")]
        public string AlternateMobileNumber { get; set; }

        [Required]
        [MaxLength(150)]
        public string AddressLine1 { get; set; }

        [MaxLength(150)]
        public string AddressLine2 { get; set; }

        [Required]
        [RegularExpression(@"^[1-9]{1}[0-9]{2}\\s{0, 1}[0-9]{3}$", ErrorMessage = "Pincode is not valid")]
        public string PinCode { get; set; }

        [Required]
        [MaxLength(25)]
        public string LandMark { get; set; }

        [Required]
        [MaxLength(15)]
        public string City { get; set; }

        [Required]
        [MaxLength(15)]
        public string Country { get; set; }

    }
}
