using System.Collections.Generic;

namespace Reflexa
{
    class RequestTypes
    {
        private List<RequestType> requestTypeList;


        public RequestTypes()
        {
            SetRequestTypes();
        }

        public List<RequestType> GetRequestTypes()
        {
            return requestTypeList;
        }

        private void SetRequestTypes()
        {
            requestTypeList = new List<RequestType>
            {
                new RequestType
                {
                    name = BuiltInRequest.LaunchRequest,
                    type = typeof(LaunchRequestHandler)
                },
                new RequestType
                {
                    name = BuiltInRequest.ReflexIntent,
                    type = typeof(ReflexIntentHandler)
                },
                new RequestType
                {
                    name = BuiltInRequest.HelpIntent,
                    type = typeof(HelpIntentHandler)
                },
                new RequestType
                {
                    name = BuiltInRequest.StopIntent,
                    type = typeof(StopIntentHandler)
                },
                new RequestType
                {
                    name = BuiltInRequest.CancelIntent,
                    type = typeof(CancelIntentHandler)
                },
                new RequestType
                {
                    name = BuiltInRequest.SessionEndedRequest,
                    type = typeof(SessionEndedRequestHandler)
                },
                new RequestType
                {
                    name = BuiltInRequest.AplUserEventRequest,
                    type = typeof(AplUserEventRequestHandler)
                }
            };
        }
    }
}
