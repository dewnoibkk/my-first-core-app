using System;

namespace MyFirstCoreApi.Identity.DbContext
{
    public interface IIdentityDbContext
    {
        Guid Id { get; }
    }
}
