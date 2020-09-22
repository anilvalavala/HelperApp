using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HelperAppDataSource;

namespace HelperAppDL.Helpers
{
    public interface IRetrieveResource<T, U> where T: IHelperDataRequest
                                             where U: IHelperDataResponse
    {
        U GetResource(T request);
    }
}
