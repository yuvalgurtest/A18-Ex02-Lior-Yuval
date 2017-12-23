using FacebookWrapper.ObjectModel;

namespace A18_Ex02_LiorBaraban_YuvalGur_BeSocial_Logic
{
    public class GameModel
    {
        public string PostText { get; set; }

        public string LinkUrl { get; set; }

        public User SelectedFriend { get; set; }

        public string PictureUrl { get; set; }
    }
}