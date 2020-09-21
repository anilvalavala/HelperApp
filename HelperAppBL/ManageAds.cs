using System;

using HelperAppBL.Requests;
using HelperAppBL.Responses;
using HelperAppDL;
using HelperAppDL.SQL;


namespace HelperAppBL
{
    public class ManageAds : IManageAds
    {
        RetrieveResource retrieveResource = new RetrieveResource(new SQLDataSource());

        public AdResponse GetAds(AdRequest adRequest)
        {
            retrieveResource.GetResource(adRequest);
            return new AdResponse();
        }
    }
}
