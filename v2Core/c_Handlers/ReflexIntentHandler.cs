using Alexa.NET.Request;
using Alexa.NET.Request.Type;
using Google.Cloud.TextToSpeech.V1;
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

                Utterance utterance = new Utterance
                {
                    Input = rawInput,
                    Time = DateTime.UtcNow
                };

                string reversed = GetReversedText(utterance.Input);

                string locale = "pl";   // lang keys needed
                string translated = GetTranslatedText(utterance.Input, locale);
                //TextToSpeechClient

                if (Echo.HasScreen)
                    PageBuilder.SetMainPage(utterance.Input);

                Logger.Write($"Original value from user: [{utterance}]");
                Logger.Write($"Reversed text: [{reversed}]");
                Logger.Write($"Translated text to {locale}: [{translated}]");  // set system locale to translated text

                Response.SetSpeech(false, false, utterance.Input, SpeechTemplate.GetWhatWouldYouNextSpeech());
                State.Utterances.Add(utterance);
                await Task.Run(() => { });
            });
        }

        private string GetReversedText(string text)
        {
            char[] letters = text.ToCharArray();
            Array.Reverse(letters);
            return new string(letters);
        }

        private string GetTranslatedText(string text, string targetLanguage)
        {
            TranslationClient client = TranslationClient.Create();
            TranslationResult result = client.TranslateText(text, targetLanguage);
            return result.TranslatedText;
        }
    }
}
