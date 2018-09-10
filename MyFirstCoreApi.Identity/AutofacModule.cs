using Autofac;
using MyFirstCoreApi.Identity.DbContext;
using MyFirstCoreApi.Identity.Managers;

namespace MyFirstCoreApi.Identity
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<IdentityDbContext>().AsImplementedInterfaces().InstancePerLifetimeScope();
            builder.RegisterType<UserManager>().AsImplementedInterfaces().SingleInstance();
        }
    }
}
