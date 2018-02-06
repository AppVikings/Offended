using System.Reflection;
using Autofac;
using MvvmCross.Core.ViewModels;
using Module = Autofac.Module;

namespace AmIOffended.Core
{
    public class CoreModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var coreAssembly = Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(coreAssembly)
                .Where(t => t.IsClass && !t.IsAbstract)
                .AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(coreAssembly)
                .AssignableTo<MvxViewModel>()
                .As<IMvxViewModel, MvxViewModel>()
                .AsSelf();
        }
    }
}
