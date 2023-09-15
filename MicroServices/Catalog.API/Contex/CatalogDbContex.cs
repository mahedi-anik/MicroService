using MongoRepo.Context;

namespace Catalog.API.Contex
{
    public class CatalogDbContex : ApplicationDbContext
    {
        public CatalogDbContex(string connectionString, string databaseName) : base(connectionString, databaseName)
        {
        }
    }
}
