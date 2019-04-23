using System.Threading.Tasks;

namespace Reflexa
{
    class SessionEndedRequestHandler : Core, IRequestHandler
    {
        public async Task HandleRequest()
        {
            await RequestProcessHelper.ProcessRequest($"{BuiltInRequest.SessionEndedRequest}", async () =>
            {
                Logger.Write("Session expired");
                await Task.Run(() => { });
            });
        }
    }
}
