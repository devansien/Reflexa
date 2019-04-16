using System;
using System.Threading.Tasks;

namespace Reflexa
{
    class RequestProcessHelper
    {
        public static async Task ProcessRequest(string requestType, Func<Task> handler)
        {
            try
            {
                Core.logger.Write($"[{requestType}] handling started");
                await handler();
                Core.logger.Write($"[{requestType}] handling completed");
            }
            catch (Exception ex)
            {
                Core.logger.Write($"Unable to process [{requestType}]");
                Core.logger.Write($"Exception detail: {ex}");
                Core.response.SetSpeech(true, false, SpeechTemplate.GetExceptionSpeech());
            }
        }
    }
}
