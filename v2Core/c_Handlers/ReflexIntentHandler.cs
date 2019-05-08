using Alexa.NET.Request;
using Alexa.NET.Request.Type;
using System;
using System.Threading.Tasks;

namespace Reflexa
{
    class ReflexIntentHandler : Core, IRequestHandler
    {
        public async Task HandleRequest()
        {
            await RequestProcessHelper.ProcessRequest($"{BuiltInRequest.ReflexIntent}", async () =>
            {
                IntentRequest request = Input.GetIntentRequest();
                Slot slot = request.Intent.Slots[SkillSettings.SentenceSlot];   // change the slot name to utterance, and also skill settings
                string rawInput = slot.Value;

                Utterance utterance = new Utterance
                {
                    Input = rawInput,
                    Time = DateTime.UtcNow
                };

                if (Echo.HasScreen)
                    PageBuilder.SetMainPage(utterance.Input);

                Logger.Write($"Raw input from user: [{utterance}]");

                Response.SetSpeech(false, false, utterance.Input, SpeechTemplate.GetWhatWouldYouNextSpeech());
                State.Utterances.Add(utterance);

                await Task.Run(() => { });
            });
        }
    }
}
