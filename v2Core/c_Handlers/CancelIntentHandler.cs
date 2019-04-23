using System.Threading.Tasks;

namespace Reflexa
{
    class CancelIntentHandler : Core, IRequestHandler
    {
        public async Task HandleRequest()
        {
            await RequestProcessHelper.ProcessRequest($"{BuiltInRequest.CancelIntent}", async () =>
            {
                Response.SetSpeech(true, false, SpeechTemplate.GetGoodbyeSpeech());
                await Task.Run(() => { });
            });
        }
    }
}
