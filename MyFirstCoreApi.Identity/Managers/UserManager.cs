using System;

namespace MyFirstCoreApi.Identity.Managers
{
    internal class UserManager : IUserManager
    {
        public UserManager()
        {
            this.Id = Guid.NewGuid();
        }

        public Guid Id { get; }
    }
}
