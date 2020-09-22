using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HelperAppDataSource;

namespace HelperAppDL.Helpers
{
    public interface IChangeResource<T, U> where T: IHelperDataRequest
                                           where U: IHelperDataResponse
    {
        U UpdateResource(T request);

        U AddResource(T request);

        U DeleteResource(T request);
    }
}
