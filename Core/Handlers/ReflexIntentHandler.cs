using Alexa.NET.Request;
using Alexa.NET.Request.Type;
using System.Threading.Tasks;

namespace Reflexa
{
    class ReflexIntentHandler : IRequestHandler
    {
        public async Task HandleRequest()
        {
            await RequestProcessHelper.ProcessRequest($"{BuiltInRequest.ReflexIntent}", async () =>
            {
                IntentRequest request = Core.input.GetIntentRequest();
                Slot slot = request.Intent.Slots[SkillSettings.SentenceSlot];
                string utterance = slot.Value;

                if (Core.echo.HasScreen)
                    AplHelper.SetMainPage(utterance);
                Sentence sentence = new Sentence { Utterance = utterance };

                //char[] rawInput = utterance.ToCharArray();
                //Array.Reverse(rawInput);
                //string reversed = new string(rawInput);

                Core.state.UserState.Sentences.Add(sentence);
                Core.logger.Write($"Raw input value from user: [{utterance}]");
                Core.response.SetSpeech(false, false, utterance, SpeechTemplate.GetWhatWouldYouNextSpeech());
                await Task.Run(() => { });
            });
        }
    }
}
