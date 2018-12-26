using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    public Text highscore;
    void Start()
    {
        
        highscore.text = PlayerPrefs.GetInt("HighScore",0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
