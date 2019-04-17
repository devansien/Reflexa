namespace Reflexa
{
    class SpeechSelectHelper
    {
        public static ISpeech GetSpeech(string locale)
        {
            switch (locale)
            {
                default:
                    return new EnPlainSpeech();
            }
        }
    }
}
