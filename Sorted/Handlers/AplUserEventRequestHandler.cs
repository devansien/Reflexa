using Alexa.NET.APL;
using System.Threading.Tasks;

namespace Reflexa
{
    class AplUserEventRequestHandler : IRequestHandler
    {
        public async Task HandleRequest()
        {
            await RequestProcessHelper.ProcessRequest($"{BuiltInRequest.AplUserEventRequest}", async () =>
            {
                UserEventRequest userRequest = Core.input.GetRequest().Request as UserEventRequest;
                string argument = userRequest.Arguments[0] as string;
                await Task.Run(() => { });
            });
        }
    }
}
