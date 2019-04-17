using Amazon.Lambda.Core;

namespace Reflexa
{
    class Logger
    {
        private ILambdaLogger logger;


        public Logger(ILambdaLogger logger)
        {
            this.logger = logger;
        }

        public void Write(string log)
        {
            logger.LogLine($"{log}");
        }
    }
}
