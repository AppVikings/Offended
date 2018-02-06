using AmIOffended.Core.Offensive;
using MvvmCross.Core.ViewModels;

namespace AmIOffended.Core.ViewModels
{
    public class OffendedViewModel : MvxViewModel
    {
        private readonly ISpeaker _speaker;

        public OffendedViewModel(ISpeaker speaker)
        {
            _speaker = speaker;
        }

        public override void ViewAppeared()
        {
            base.ViewAppeared();

            _speaker.Speak("You should be offended!");
        }
    }
}
