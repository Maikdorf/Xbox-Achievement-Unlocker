namespace Xbox_Achievement_Unlocker.Class.Objects
{
    internal class Game
    {
        private string[] _devices;
        private string _displayImage;
        private string _titleId;
        private string _modernTitleId;
        private int    _progressPercentage;
        private string _totalGamerscore;
        private string _currentAchievements;
        private string _name;
        private string _Scid;

        public string Name { get => _name; set => _name = value; }
        public string DisplayImage { get => _displayImage; set => _displayImage = value; }
        public string TitleId { get => _titleId; set => _titleId = value; }
        public string ModernTitleId { get => _modernTitleId; set => _modernTitleId = value; }
        public int ProgressPercentage { get => _progressPercentage; set => _progressPercentage = value; }
        public string TotalGamerscore { get => _totalGamerscore; set => _totalGamerscore = value; }
        public string CurrentAchievements { get => _currentAchievements; set => _currentAchievements = value; }
        public string Scid { get => _Scid; set => _Scid = value; }
        public string[] Devices { get => _devices; set => _devices = value; }
    }
}
