using System;

namespace MyFirstCoreApi.Identity.DbContext
{
    internal class IdentityDbContext : Microsoft.EntityFrameworkCore.DbContext, IIdentityDbContext
    {
        public IdentityDbContext()
        {
            this.Id = Guid.NewGuid();
        }

        public Guid Id { get; }
    }
}
