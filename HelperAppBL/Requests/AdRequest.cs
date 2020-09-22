using System.ComponentModel.DataAnnotations;

using HelperAppDataSource;

namespace HelperAppBL.Requests
{
    public class AdRequest : IHelperDataRequest
    {
        [DataType(DataType.Date)]
        public string StartDate { get; set; }

        [DataType(DataType.Date)]
        public string EndDate { get; set; }

        public string Category { get; set; }

        public string SubCategory { get; set; }

        public string AdOwnerId { get; set; }

    }
}
