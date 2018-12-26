using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneSelectScript : MonoBehaviour
{
    public void selectScene()
    {
        switch (this.gameObject.name)
        {
            case "PlayButton":
                SceneManager.LoadScene("SampleScene");
                break;
            case "HighScoreButton":
                SceneManager.LoadScene("SampleScene");
                break;
            case "LeaderBoard":
                PlayGameScript.ShowLeaderBoardUI();
                break;
            case "LeaderBoardd":
                PlayGameScript.ShowLeaderBoardUI();
                break;

        }
    }
}
