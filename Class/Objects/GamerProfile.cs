namespace Xbox_Achievement_Unlocker.Class.Objects
{
    internal class GamerProfile
    {
        private string _gameDisplayPicRaw;
        private string _xUID;
        private string _gamerTag;
        private string _gamerScore;
        private string _xAuthToken;

        public string XUID { get => _xUID; set => _xUID = value; }
        public string GamerTag { get => _gamerTag; set => _gamerTag = value; }
        public string GamerScore { get => _gamerScore; set => _gamerScore = value; }
        public string GameDisplayPicRaw { get => _gameDisplayPicRaw; set => _gameDisplayPicRaw = value; }
        public string XAuthToken { get => _xAuthToken; set => _xAuthToken = value; }
    }
}