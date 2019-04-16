using System.Threading.Tasks;

namespace Reflexa
{
    class HelpIntentHandler : IRequestHandler
    {
        public async Task HandleRequest()
        {
            await RequestProcessHelper.ProcessRequest($"{BuiltInRequest.HelpIntent}", async () =>
            {
                Core.response.SetSpeech(false, false,
                    SpeechTemplate.GetDetailedHelpSpeech() + SpeechTemplate.GetWhatWouldYouSpeech(),
                    SpeechTemplate.GetShortHelpSpeech() + SpeechTemplate.GetWhatWouldYouSpeech());

                await Task.Run(() => { });
            });
        }
    }
}
