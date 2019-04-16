using Alexa.NET.APL;
using Alexa.NET.Request;
using Amazon.Lambda.Core;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;

namespace Reflexa
{
    class Core
    {
        public static ISpeech speech;

        public static Echo echo;
        public static Input input;
        public static Logger logger;
        public static Database database;
        public static Response response;
        public static State state;

        public static RequestTypes requestTypes;
        public static List<RequestType> customRequestTypes;


        public async Task Init(APLSkillRequest request, ILambdaContext context)
        {
            AddRequestConverters();

            logger = new Logger(context.Logger);
            logger.Write($"**************** [{Skill.Title}] started ****************");
            logger.Write($"System locale: [{request.Request.Locale}]");
            logger.Write($"Request detail: {JsonConvert.SerializeObject(request)}");

            speech = SpeechSelectHelper.GetSpeech(request.Request.Locale);
            string userId = GetUserId(request);
            SetComponents(request, userId);
            await SetState();
        }

        private void SetComponents(APLSkillRequest request, string userId)
        {
            input = new Input(request);
            echo = new Echo();
            database = new Database(userId);
            response = new Response();
            requestTypes = new RequestTypes();
        }

        private async Task SetState()
        {
            database.SetContext();
            state = await database.GetState();
            logger.Write($"Retrieved user state detail: {JsonConvert.SerializeObject(state)}");
        }

        private string GetUserId(APLSkillRequest request)
        {
            Session session = request.Session;
            APLContext skillContext = request.Context;

            return session != null ? session.User.UserId : skillContext.System.User.UserId;
        }

        public object GetHandlerInstance()
        {
            string requestName = input.GetRequestName();
            logger.Write($"Request type: [{requestName}]");

            List<RequestType> requestTypeList = requestTypes.GetRequestTypes();
            foreach (RequestType requestType in requestTypeList)
            {
                if (requestName.Equals(requestType.name))
                    return Activator.CreateInstance(requestType.type);
            }

            return null;
        }

        public MethodBase GetRequestHandler(Type requestType)
        {
            MethodBase handler = requestType.GetMethod(BuiltInRequest.RequestHandler,
                BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

            return handler;
        }

        private void AddRequestConverters()
        {
            new UserEventRequestHandler().AddToRequestConverter();
            //new SystemExceptionEncounteredRequestTypeConverter().AddToRequestConverter();
        }
    }
}
