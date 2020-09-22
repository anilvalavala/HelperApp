using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HelperAppDataSource;
using HelperAppDL.Helpers;

namespace HelperAppDL
{
    /// <summary>
    /// Will be called from BL
    /// </summary>
    public class RetrieveResource : IRetrieveResource<IHelperDataRequest, IHelperDataResponse>
    {
        IDataSource dataSource;

        //Pass object of SQLDataSource here
        public RetrieveResource(IDataSource dataSource)
        {
            this.dataSource = dataSource;
        }

        public IHelperDataResponse GetResource(IHelperDataRequest request)
        {
            return dataSource.GetResource(request);
        }

    }
}
