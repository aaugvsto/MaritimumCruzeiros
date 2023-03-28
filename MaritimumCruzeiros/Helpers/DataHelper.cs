using MaritimumCruzeiros.Data;
using Microsoft.EntityFrameworkCore;

namespace MaritimumCruzeiros.Helpers
{
    public class DataHelper
    {
        public static async Task ManageDataAsync(IServiceProvider svcProvider)
        {
            //Service: An instance of db context
            var dbContextSvc = svcProvider.GetRequiredService<DBContext>();

            //Migration: This is the programmatic equivalent to Update-Database
            await dbContextSvc.Database.MigrateAsync();
        }
    }
}
