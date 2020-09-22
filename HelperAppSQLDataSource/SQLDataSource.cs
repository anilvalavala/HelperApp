using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HelperAppDataSource;

namespace HelperAppSQLDataSource
{
    public class SQLDataSource : IDataSource
    {
        //string connectionString = @"Data Source=local;Initial Catalog = HelperApp;User ID = sa;Password=india123";

        //open connection and pass it on to subsequent classes

        public IHelperDataResponse GetResource(IHelperDataRequest request)
        {
            IDataSource resourceManager = GetResourceManager(request);

            return resourceManager.GetResource(request);
        }

        public IHelperDataResponse UpdateResource(IHelperDataRequest request)
        {
            IDataSource resourceManager = GetResourceManager(request);

            return resourceManager.UpdateResource(request);
        }

        public IHelperDataResponse AddResource(IHelperDataRequest request)
        {
            IDataSource resourceManager = GetResourceManager(request);

            return resourceManager.AddResource(request);
        }

        public IHelperDataResponse DeleteResource(IHelperDataRequest request)
        {
            IDataSource resourceManager = GetResourceManager(request);

            return resourceManager.DeleteResource(request);
        }

        public IDataSource GetResourceManager(IHelperDataRequest request)
        {
            string typeName = request.GetType().Name;

            IDataSource objectToReturn;

            switch (typeName)
            {
                case "AdRequest":
                    objectToReturn = new SQLAdManager();
                    break;
                case "UserRequest":
                    objectToReturn = new SQLUserManager();
                    break;
                default:
                    objectToReturn = null;
                    break;
            }

            return objectToReturn;
        }

    }
}
