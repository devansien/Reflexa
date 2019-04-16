using System.Threading.Tasks;

namespace Reflexa
{
    class CancelIntentHandler : IRequestHandler
    {
        public async Task HandleRequest()
        {
            await RequestProcessHelper.ProcessRequest($"{BuiltInRequest.CancelIntent}", async () =>
            {
                Core.response.SetSpeech(true, false, SpeechTemplate.GetGoodbyeSpeech());
                await Task.Run(() => { });
            });
        }
    }
}
