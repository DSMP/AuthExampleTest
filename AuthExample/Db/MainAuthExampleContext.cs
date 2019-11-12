using AuthExampleLibrary.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuthExample.Db
{
    public class MainAuthExampleContext : AuthExampleContext
    {
        private DbContextOptions<AuthExampleContext> options;

        public MainAuthExampleContext(DbContextOptions<AuthExampleContext> options) : base(options)
        {
            this.options = options;
        }
    }
}
