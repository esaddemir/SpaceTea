using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine;

public class PlayGameScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder().Build();
        PlayGamesPlatform.InitializeInstance(config);
        PlayGamesPlatform.Activate();

        SignIn();
    }

    void SignIn()
    {
        Social.localUser.Authenticate(success => { });
    }

    #region LeaderBoards
    public static void AddScoreToLeaderboard(string leaderboardId , int score)
    {
        Social.ReportScore(score, leaderboardId, success => { });
    }

    public static void ShowLeaderBoardUI()
    {
        Social.ShowLeaderboardUI();
    }
    #endregion /LeaderBoards

}
