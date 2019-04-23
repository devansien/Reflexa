using System.Threading.Tasks;

namespace Reflexa
{
    class StopIntentHandler : Core, IRequestHandler
    {
        public async Task HandleRequest()
        {
            await RequestProcessHelper.ProcessRequest($"{BuiltInRequest.StopIntent}", async () =>
            {
                Response.SetSpeech(true, false, SpeechTemplate.GetGoodbyeSpeech());
                await Task.Run(() => { });
            });
        }
    }
}
