using System.Reflection;
using Autofac;
using Module = Autofac.Module;

namespace AmIOffended.Droid
{
    internal class DroidModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .Where(t => t.IsClass && !t.IsAbstract)
                .AsImplementedInterfaces();
        }
    }
}
