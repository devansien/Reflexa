using System.Threading.Tasks;

namespace Reflexa
{
    class SessionEndedRequestHandler : IRequestHandler
    {
        public async Task HandleRequest()
        {
            await RequestProcessHelper.ProcessRequest($"{BuiltInRequest.SessionEndedRequest}", async () =>
            {
                Core.logger.Write("Session expired");
                await Task.Run(() => { });
            });
        }
    }
}
