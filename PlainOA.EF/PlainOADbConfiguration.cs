using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlainOA.EF
{
   public class PlainOADbConfiguration : DbConfiguration
    {
        public PlainOADbConfiguration() {
            SetTransactionHandler(SqlProviderServices.ProviderInvariantName, () => new CommitFailureHandler());
            //SetExecutionStrategy(SqlProviderServices.ProviderInvariantName,()=>new SqlAzureExecutionStrategy());
            //SetDefaultConnectionFactory(new LocalDbConnectionFactory("v11.0"));
        }
    }
}
