using Alexa.NET;
using Alexa.NET.Request;
using Alexa.NET.Response;
using Alexa.NET.Response.Directive;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reflexa
{
    class Response
    {
        private SkillResponse response;


        public Response()
        {
            response = ResponseBuilder.Empty();
        }

        public SkillResponse GetResponse()
        {
            return response;
        }

        public void SetSession()
        {
            Session session = Core.input.GetRequest().Session;
            if (session != null && session.Attributes != null)
                response.SessionAttributes = session.Attributes;
        }

        public void SetDirective(bool clear, IDirective directive)
        {
            if (clear)
                ClearDirective();
            response.Response.Directives.Add(directive);
        }

        public void SetDirective(params IDirective[] directives)
        {
            foreach (IDirective directive in directives)
                response.Response.Directives.Add(directive);
        }

        public void SetSpeech(bool endSession, bool isSsml, string speech, params string[] reprompts)
        {
            string reprompt = string.Empty;

            if (reprompts.Any())
                reprompt = GetReprompt(reprompts);
            if (isSsml)
                response.Response.OutputSpeech = new SsmlOutputSpeech() { Ssml = speech };
            else
                response.Response.OutputSpeech = new PlainTextOutputSpeech() { Text = speech };
            if (!string.IsNullOrEmpty(reprompt))
                response.Response.Reprompt = new Reprompt(reprompt);

            response.Response.ShouldEndSession = endSession;
        }

        private string GetReprompt(string[] reprompts)
        {
            StringBuilder builder = new StringBuilder();
            foreach (string reprompt in reprompts)
                builder.Append(reprompt);

            return builder.ToString();
        }

        private void ClearDirective()
        {
            if (response.Response.Directives == null)
                return;

            List<IDirective> newDirectives = new List<IDirective>();
            foreach (var directive in response.Response.Directives)
            {
                if (directive.GetType() != typeof(VideoAppDirective) &&
                    directive.GetType() != typeof(RenderDocumentDirective) &&
                    directive.GetType() != typeof(AudioPlayerPlayDirective) &&
                    directive.GetType() != typeof(ExecuteCommandsDirective))

                    newDirectives.Add(directive);
            }

            response.Response.Directives = newDirectives;
        }
    }
}
