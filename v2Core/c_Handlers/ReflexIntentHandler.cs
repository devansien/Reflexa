using Alexa.NET.Request;
using Alexa.NET.Request.Type;
using Amazon.Polly;
using Amazon.Polly.Model;
using Amazon.S3;
using Amazon.S3.Model;
//using Google.Cloud.TextToSpeech.V1;
using Google.Cloud.Translation.V2;
//using NAudio.Lame;
//using NAudio.Wave;
using System;
using System.IO;
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

                //string locale = "pl";   // lang keys needed
                //string translated = GetTranslatedText(utterance.Input, locale);

                //string accessKey = Environment.GetEnvironmentVariable(SessionKey.DbAccessKey);
                //string secretKey = Environment.GetEnvironmentVariable(SessionKey.DbSecretKey);


                //var client = TextToSpeechClient.Create();

                //var input = new SynthesisInput
                //{
                //    Text = rawInput
                //};

                //var voiceSelection = new VoiceSelectionParams
                //{
                //    LanguageCode = "en-US",
                //    SsmlGender = SsmlVoiceGender.Female
                //};

                //var audioConfig = new AudioConfig
                //{
                //    AudioEncoding = AudioEncoding.Linear16,
                //};

                //var response = client.SynthesizeSpeech(input, voiceSelection, audioConfig);



                //AmazonPollyClient pc = new AmazonPollyClient(accessKey, secretKey);
                //SynthesizeSpeechRequest sreq = new SynthesizeSpeechRequest();
                //sreq.Text = translated;
                ////sreq.LanguageCode = LanguageCode.JaJP;
                //sreq.OutputFormat = OutputFormat.Mp3;
                //sreq.VoiceId = VoiceId.Jacek;
                //SynthesizeSpeechResponse sres = await pc.SynthesizeSpeechAsync(sreq);

                //MemoryStream m = new MemoryStream();
                //sres.AudioStream.CopyTo(m);


                //using (var fileStream = File.Create(@"c:\yourfile.mp3"))
                //{
                //    sres.AudioStream.CopyTo(fileStream);
                //    fileStream.Flush();
                //    fileStream.Close();
                //}


                string url = string.Empty;

                //MemoryStream waveStream = new MemoryStream(bytes);
                //using (var reader = new Mp3FileReader(new MemoryStream(bytes)))
                //{
                //    MemoryStream tempMemo = new MemoryStream();
                //    WaveFileWriter.WriteWavFileToStream(tempMemo, reader);


                //using (var waveReader = new WaveFileReader(mp3memo))
                //{


                //}

                //}
                //var target = new WaveFormat(8000, 16, 1);
                //using (var outPutStream = new MemoryStream())
                //using (var waveStream = new WaveFileReader(new MemoryStream(bytes)))
                //using (var conversionStream = new WaveFormatConversionStream(target, waveStream))
                //using (var writer = new LameMP3FileWriter(outPutStream, conversionStream.WaveFormat, 32, null))
                //{
                //    await conversionStream.CopyToAsync(writer);

                //    outPutStream.ToArray();

                //    Logger.Write("AAAAAAA");
                //}
                Logger.Write(Directory.GetCurrentDirectory());





                //using (MemoryStream memoryStream = new MemoryStream(m.ToArray()))
                //{




                //    AmazonS3Client s3Client = new AmazonS3Client(accessKey, secretKey);

                //    bool isFound = false;
                //    string bucketName = "reflexademo";
                //    ListBucketsResponse listBucketsResponse = await s3Client.ListBucketsAsync();
                //    foreach (S3Bucket bucket in listBucketsResponse.Buckets)
                //    {
                //        if (bucket.BucketName == bucketName)
                //        {
                //            isFound = true;
                //            break;
                //        }
                //    }

                //    if (isFound == false)
                //    {
                //        await s3Client.PutBucketAsync(new PutBucketRequest
                //        {
                //            BucketName = bucketName
                //        });
                //    }

                //    // file in folder >> "folder/"+"filename"
                //    string folderName = "myfolder/" + "demovoice.mp3";
                //    PutObjectRequest putObjectRequest = new PutObjectRequest();
                //    putObjectRequest.BucketName = bucketName;
                //    putObjectRequest.Key = folderName;
                //    putObjectRequest.InputStream = memoryStream;
                //    putObjectRequest.CannedACL = S3CannedACL.PublicRead;
                //    putObjectRequest.AutoCloseStream = true;
                //    //putObjectRequest.ContentBody = "";
                //    await s3Client.PutObjectAsync(putObjectRequest);


                //    url = $"https://s3.amazonaws.com/{bucketName}/{folderName}";


                //    //url = s3Client.GetPreSignedURL(new GetPreSignedUrlRequest()
                //    //{
                //    //    BucketName = bucketName,
                //    //    Key = folderName,
                //    //    Expires = DateTime.Now.AddMinutes(1000)
                //    //});

                //    //PutACLResponse aclresponse = await s3Client.PutACLAsync(new PutACLRequest()
                //    //{
                //    //    CannedACL = S3CannedACL.PublicRead,
                //    //    BucketName = bucketName,
                //    //    Key = folderName

                //    //});


                //}











                //using (var output = File.Create("output.mp3"))
                //{
                //    response.AudioContent.WriteTo(output);

                //    Logger.Write(Directory.GetCurrentDirectory());

                //    string[] files = Directory.GetFiles(Directory.GetCurrentDirectory());

                //    foreach (string file in files)
                //    {
                //        Logger.Write(file);
                //    }
                //}





                if (Echo.HasScreen)
                    PageBuilder.SetMainPage(utterance.Input);

                Logger.Write($"Original value from user: [{utterance}]");
                Logger.Write($"Reversed text: [{reversed}]");
                //Logger.Write($"Translated text to {locale}: [{translated}]");  // set system locale to translated text

                //Response.SetSpeech(false, false, utterance.Input, SpeechTemplate.GetWhatWouldYouNextSpeech());

                //Response.SetSpeech(false, true, $"<speak><audio src=\"{url}\" /></speak>", SpeechTemplate.GetWhatWouldYouNextSpeech());
                Response.SetSpeech(false, false, rawInput, SpeechTemplate.GetWhatWouldYouNextSpeech());
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
