using System.Threading.Tasks;

namespace Reflexa
{
    class StopIntentHandler : IRequestHandler
    {
        public async Task HandleRequest()
        {
            await RequestProcessHelper.ProcessRequest($"{BuiltInRequest.StopIntent}", async () =>
            {
                Core.response.SetSpeech(true, false, SpeechTemplate.GetGoodbyeSpeech());
                await Task.Run(() => { });
            });
        }
    }
}
