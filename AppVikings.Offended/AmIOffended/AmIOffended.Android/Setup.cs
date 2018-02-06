using AmIOffended.Core;
using Android.Content;
using Autofac;
using Autofac.Extras.MvvmCross;
using MvvmCross.Core.ViewModels;
using MvvmCross.Forms.Droid.Platform;
using MvvmCross.Forms.Platform;
using MvvmCross.Platform.IoC;

namespace AmIOffended.Droid
{
    public class Setup : MvxFormsAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new CoreApp();
        }

        protected override IMvxIoCProvider CreateIocProvider()
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule<CoreModule>()
                   .RegisterModule<DroidModule>();

            return new AutofacMvxIocProvider(builder.Build());
        }

        protected override MvxFormsApplication CreateFormsApplication()
        {
            return new Core.App();
        }
    }
}
