namespace A18_Ex02_LiorBaraban_YuvalGur_BeSocial_Logic
{
    public interface ISocialMission
    {
        string Description { get; set; }

        GameModel MissionModel { get; set; }

        int ScoreValue { get; set; }

        bool IsFulfilled();
    }
}