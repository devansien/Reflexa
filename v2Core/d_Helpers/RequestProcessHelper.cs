using System;
using System.Threading.Tasks;

namespace Reflexa
{
    class RequestProcessHelper : Core
    {
        public static async Task ProcessRequest(string requestType, Func<Task> handler)
        {
            try
            {
                Logger.Write($"[{requestType}] handling started");
                await handler();
                Logger.Write($"[{requestType}] handling completed");
            }
            catch (Exception ex)
            {
                Logger.Write($"Unable to process [{requestType}]");
                Logger.Write($"Exception detail: {ex}");
                Response.SetSpeech(true, false, SpeechTemplate.GetExceptionSpeech());
            }
        }
    }
}
