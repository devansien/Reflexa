using Alexa.NET.Request;
using Alexa.NET.Response;
using Amazon.Lambda.Core;
using Newtonsoft.Json;
using System.Reflection;
using System.Threading.Tasks;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace Reflexa
{
    public class Function
    {
        public async Task<SkillResponse> FunctionHandler(APLSkillRequest request, ILambdaContext context)
        {
            Core core = new Core();
            await core.Init(request, context);
            await InvokeHandler(core);

            await Core.database.SaveState();
            SkillResponse response = Core.response.GetResponse();
            Core.logger.Write($"Response detail: {JsonConvert.SerializeObject(response)}");
            Core.logger.Write($"Latest user state detail: {JsonConvert.SerializeObject(Core.state)}");
            Core.logger.Write($"**************** [{SkillSettings.Title}] processing ended ****************");

            return response;
        }

        private async Task InvokeHandler(Core core)
        {
            object handlerInstance = core.GetHandlerInstance();
            if (handlerInstance != null)
            {
                MethodBase handler = core.GetRequestHandler(handlerInstance.GetType());
                await (Task)handler.Invoke(handlerInstance, null);
            }
        }
    }
}
