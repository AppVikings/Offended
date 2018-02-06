using System;
using AmIOffended.Core.Offensive;
using MvvmCross.Core.ViewModels;

namespace AmIOffended.Core.ViewModels
{
    public class OffendedViewModel : MvxViewModel
    {
        private readonly ISpeaker _speaker;
        private readonly IShrink _shrink;
        private string _offendedResultText;

        public OffendedViewModel(ISpeaker speaker, IShrink shrink)
        {
            _speaker = speaker;
            _shrink = shrink;

            CheckIfImOffended = new MvxCommand(() =>
            {
                OffendedState myState = _shrink.AmIOffended();
                switch (myState)
                {
                    case OffendedState.NotOffended:
                        OffendedResultText = "You have absolutely no reason to be offended";
                        break;
                    case OffendedState.Offended:
                        OffendedResultText = "You should be offended!";
                        break;
                    case OffendedState.VeryOffended:
                        OffendedResultText = "OMG! The level of offended you should be has reached epic!";
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                _speaker.Speak(OffendedResultText);
            });
        }

        public string OffendedResultText
        {
            get => _offendedResultText;
            set
            {
                _offendedResultText = value;
                RaisePropertyChanged(() => OffendedResultText);
            }
        }

        public MvxCommand CheckIfImOffended { get; }
    }
}
