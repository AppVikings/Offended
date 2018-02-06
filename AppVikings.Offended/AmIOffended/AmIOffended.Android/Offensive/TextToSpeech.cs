using AmIOffended.Core.Offensive;
using Android.Speech.Tts;
using Java.Lang;
using Xamarin.Forms;

[assembly: Dependency(typeof(TextToSpeech))]

namespace AmIOffended.Droid.Offensive
{
    internal class Speaker : Object, ISpeaker, TextToSpeech.IOnInitListener
    {
        private TextToSpeech _speaker;
        private string _toSpeak;

        public void Speak(string text)
        {
            _toSpeak = text;
            if (_speaker == null)
                _speaker = new TextToSpeech(Forms.Context, this);
            else
                _speaker.Speak(_toSpeak, QueueMode.Flush, null, null);
        }

        public void OnInit(OperationResult status)
        {
            if (status.Equals(OperationResult.Success)) _speaker.Speak(_toSpeak, QueueMode.Flush, null, null);
        }
    }
}
