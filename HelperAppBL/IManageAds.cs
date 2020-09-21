using System;
using System.Collections.Generic;

using HelperAppBL.Requests;
using HelperAppBL.Responses;

namespace HelperAppBL
{
    public interface IManageAds
    {
        AdResponse GetAds(AdRequest adRequest);
    }
}
