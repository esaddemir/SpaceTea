using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SpaceShip : MonoBehaviour
{
    private Rigidbody2D rb;
    private float jumpForce = 60f;
    private bool engineIsOn;

    [SerializeField]
    private GameObject fire;
    public static int fuelAmount;
    public Transform cometObject;
    public Text fuelMeter;
    // Start is called before the first frame update
    private void Start()
    {
        Time.timeScale = 1f;
        engineIsOn = false;
        fire.SetActive(false);
        rb = GetComponent<Rigidbody2D>();

        fuelAmount = 100;
    }

    // Update is called once per frame
    private void Update()
    {
        //Yakıt artıyor
        fuelMeter.text = "Yakıt: " + fuelAmount.ToString() + "%";
        if (fuelAmount == 0)
        {
            engineIsOn = false;
            fire.SetActive(false);
        }
        //if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began&&fuelAmount>0)
        if(Input.GetMouseButtonDown(0) && fuelAmount >0)
        {
            engineIsOn = true;
            fire.SetActive(true);
            StartCoroutine(BurnFuel());
        }

        //if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        if (Input.GetMouseButtonUp(0)) 
        {
            engineIsOn = false;
            fire.SetActive(false);
        }
        if (transform.position.y >= cometObject.position.y + 5f)
        {
            cometObject.position = new Vector2(cometObject.position.x, transform.position.y + 40f);
        }
    }
    public void FixedUpdate()
    {
        if (engineIsOn)
        {
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Force);
        }
        else { rb.AddForce(new Vector2(0f, 0f), ForceMode2D.Force); }
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Comets>())
        {
            StartCoroutine("ReloadScene");
            Time.timeScale = 0f;
            
        }
        
    }
    public IEnumerator ReloadScene()
    {
        PlayGameScript.AddScoreToLeaderboard(GPGSIds.leaderboard_space_tea_leader_board, PlayerPrefs.GetInt("HighScore", 0));
        yield return new WaitForSecondsRealtime(0.5f);
        SceneManager.LoadScene("MainScene");
    }
    public IEnumerator BurnFuel()
    {
        for (int i = fuelAmount; i >= 1; i--)
        {
            fuelAmount -= 1;
            yield return new WaitForSeconds(0.01f);

            //if(Input.touchCount >0 && Input.GetTouch(0).phase==TouchPhase.Ended)
            if (Input.GetMouseButtonUp(0))
                break;
            if (fuelAmount == 0f)
            {
                StartCoroutine("ReloadScene");
            }
        }
    }
}
