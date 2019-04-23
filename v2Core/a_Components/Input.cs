using Alexa.NET.Request;
using Alexa.NET.Request.Type;

namespace Reflexa
{
    public class Input
    {
        private APLSkillRequest request;
        private IntentRequest intentRequest;


        public Input(APLSkillRequest request)
        {
            this.request = request;
            intentRequest = request.Request as IntentRequest;
        }

        public APLSkillRequest GetRequest()
        {
            return request;
        }

        public IntentRequest GetIntentRequest()
        {
            return intentRequest;
        }

        public string GetRequestName()
        {
            string requestName;
            if (intentRequest != null)
                requestName = intentRequest.Intent.Name;
            else
                requestName = request.Request.Type;

            return requestName;
        }
    }
}
