using System;
using System.Collections.Generic;

using HelperAppDataSource;
using HelperAppDL.Models;

namespace HelperAppBL.Responses
{
    public class AdResponse : IHelperDataResponse
    {
        public AdResponse()
        {
            Ads = new List<Advertisement>();
        }

        public List<Advertisement> Ads { get; set; }
    }
}
