using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Money : MonoBehaviour
{
    public int moneyAmount;
    public Transform coinObject;

    [SerializeField]
    public Text coinCounter;
    
    void Start()
    {
        moneyAmount = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        coinCounter.text = "Coins: " + moneyAmount.ToString();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<Coin>())
        {
            moneyAmount += 1;
            coinObject.position = new Vector2(coinObject.position.x, coinObject.position.y + 15f);



            if(moneyAmount >PlayerPrefs.GetInt("HighScore" , 0))
            {
                PlayerPrefs.SetInt("HighScore", moneyAmount);             
            }
            
            
        }
    }
}
