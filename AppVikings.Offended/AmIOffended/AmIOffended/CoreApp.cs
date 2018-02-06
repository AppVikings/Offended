using AmIOffended.Core.ViewModels;
using MvvmCross.Core.ViewModels;

namespace AmIOffended.Core
{
    public class CoreApp : MvxApplication
    {
        public override void Initialize()
        {
            RegisterNavigationServiceAppStart<OffendedViewModel>();
        }
    }
}
