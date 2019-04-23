using System.Threading.Tasks;

namespace Reflexa
{
    class LaunchRequestHandler : Core, IRequestHandler
    {
        public async Task HandleRequest()
        {
            await RequestProcessHelper.ProcessRequest($"{BuiltInRequest.LaunchRequest}", async () =>
            {
                State.UserState.NumPlayed++;
                if (Echo.HasScreen)
                    PageBuilder.SetMainPage("Say something to repeat....");

                Response.SetSpeech(false, false,
                    SpeechTemplate.GetWelcomeSpeech() + SpeechTemplate.GetShortHelpSpeech() + SpeechTemplate.GetWhatWouldYouSpeech(),
                    SpeechTemplate.GetShortHelpSpeech() + SpeechTemplate.GetWhatWouldYouSpeech());
                await Task.Run(() => { });
            });
        }
    }
}
