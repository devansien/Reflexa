using System.Threading.Tasks;

namespace Reflexa
{
    class LaunchRequestHandler : IRequestHandler
    {
        public async Task HandleRequest()
        {
            await RequestProcessHelper.ProcessRequest($"{BuiltInRequest.LaunchRequest}", async () =>
            {
                Core.state.UserState.NumPlayed++;

                if (Core.echo.HasScreen)
                    AplHelper.SetMainPage("Say something to repeat....");

                Core.response.SetSpeech(false, false,
                    SpeechTemplate.GetWelcomeSpeech() + SpeechTemplate.GetShortHelpSpeech() + SpeechTemplate.GetWhatWouldYouSpeech(),
                    SpeechTemplate.GetShortHelpSpeech() + SpeechTemplate.GetWhatWouldYouSpeech());

                await Task.Run(() => { });
            });
        }
    }
}
