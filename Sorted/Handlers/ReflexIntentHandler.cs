using System.Threading.Tasks;

namespace Reflexa
{
    class ReflexIntentHandler : IRequestHandler
    {
        public async Task HandleRequest()
        {
            await RequestProcessHelper.ProcessRequest($"{BuiltInRequest.ReflexIntent}", async () =>
            {
                await Task.Run(() => { });
            });
        }
    }
}
