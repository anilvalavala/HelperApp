using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperAppDataSource
{
    public interface IDataSource
    {
        IHelperDataResponse GetResource(IHelperDataRequest request);

        IHelperDataResponse UpdateResource(IHelperDataRequest request);

        IHelperDataResponse AddResource(IHelperDataRequest request);

        IHelperDataResponse DeleteResource(IHelperDataRequest request);
    }
}
