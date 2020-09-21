using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using HelperAppBL;
using HelperAppBL.Requests;


namespace HelperApp.Controllers
{
    [Route("ad")]
    public class AdController : ControllerBase
    {
        //IManageAds manageAds;

        //public AdController(IManageAds manageAds)
        //{
        //    this.manageAds = manageAds;
        //}

        ManageAds manageAds = new ManageAds();

        [HttpGet]
        public IActionResult Get(AdRequest adRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(manageAds.GetAds(adRequest));

        }
    }
}
