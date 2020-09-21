using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HelperAppDL.Helpers;

namespace HelperAppDL
{
    /// <summary>
    /// Will be called from BL
    /// </summary>
    public class ChangeResource : IChangeResource<IHelperDataRequest, IHelperDataResponse>
    {
        IDataSource dataSource;

        public ChangeResource(IDataSource dataSource)
        {
            this.dataSource = dataSource;
        }

        public IHelperDataResponse UpdateResource(IHelperDataRequest request)
        {
            return dataSource.UpdateResource(request);
        }

        public IHelperDataResponse AddResource(IHelperDataRequest request)
        {
            return dataSource.AddResource(request);
        }

        public IHelperDataResponse DeleteResource(IHelperDataRequest request)
        {
            return dataSource.DeleteResource(request);
        }
    }
}
