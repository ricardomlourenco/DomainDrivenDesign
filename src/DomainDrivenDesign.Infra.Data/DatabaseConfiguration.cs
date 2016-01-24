using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.SqlServer;

namespace DomainDrivenDesign.Infra.Data
{
    /// <summary>
    /// ORM Configuration such as Provider Name
    /// Note: You have to decorate this Attribute in the Context class DefaultORMContext
    /// </summary>
    /// <example>
    /// [DbConfigurationType(typeof(DatabaseConfiguration))]
    /// public class DefaultORMContext : DbContext {}
    /// </example>
    public class DatabaseConfiguration : DbConfiguration
    {
        public DatabaseConfiguration()
        {
            //SetExecutionStrategy("System.Data.SqlClient", () => new sql());
            base.SetProviderServices(SqlProviderServices.ProviderInvariantName, SqlProviderServices.Instance);
            SetDefaultConnectionFactory(new LocalDbConnectionFactory("v11.0"));
        }
    }
}
