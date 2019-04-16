namespace Reflexa
{
    class SessionKey
    {
        // query
        public const string Title = "Title";
        public const string Index = "Index";
        public const string Artist = "Artist";

        // database
        public const string DbHashKey = "UserId";
        public const string DbTableName = "MediaState";
        public const string DbAccessKey = "DbAccessKey";
        public const string DbSecretKey = "DbSecretKey";

        // tokens
        public const string MainToken = "MainToken";
        public const string DefaultToken = "DefaultToken";
        public const string SpotAplToken = "SpotAPLToken";
        public const string ShowAplToken = "ShowAPLToken";
        public const string MenuAplToken = "MenuAPLToken";
        public const string AplVideoToken = "APLVideoToken";
        public const string SelectedMediaToken = "SelectedMediaToken";

        // skill
        public const string Queried = "Queried";
        public const string SecondHalf = "SecondHalf";
        public const string SelectedItem = "SelectedItem";
        public const string CachedOutput = "CachedOutput";
        public const string CachedReprompt = "CachedReprompt";

        // session
        public const string Token = "token";
        public const string Playing = "PLAYING";
        public const string Viewport = "viewport";
        public const string VideoPlayer = "VideoPlayer";
        public const string AlexaPresentationApl = "Alexa.Presentation.APL";
        public const string AlexaPlayPauseToggleButton = "alexaPlayPauseToggleButton";

        // events
        public const string OnEnd = "OnEnd";
        public const string OnPlay = "OnPlay";
        public const string OnPause = "OnPause";
        public const string OnTrackUpdate = "OnTrackUpdate";
    }
}
