using Alexa.NET.Request;
using Alexa.NET.Request.Type;
using Google.Cloud.Translation.V2;
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

                if (Echo.HasScreen)
                    PageBuilder.SetMainPage(rawInput);

                Utterance utterance = new Utterance
                {
                    Input = rawInput,
                    Time = DateTime.UtcNow
                };

                char[] letters = utterance.Input.ToCharArray();
                Array.Reverse(letters);
                string reversed = new string(letters);

                string targetLanguage = "pl";   // lang keys needed
                TranslationClient client = TranslationClient.Create();
                TranslationResult translated = client.TranslateText(utterance.Input, targetLanguage);

                Logger.Write($"Original value from user: [{utterance}]");
                Logger.Write($"Reversed text: [{reversed}]");
                Logger.Write($"Translated text to {targetLanguage}: [{translated.TranslatedText}]");  // set system locale to translated text

                Response.SetSpeech(false, false, utterance.Input, SpeechTemplate.GetWhatWouldYouNextSpeech());
                State.Utterances.Add(utterance);
                await Task.Run(() => { });
            });
        }
    }
}
