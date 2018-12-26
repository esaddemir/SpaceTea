using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackGround : MonoBehaviour
{
    [SerializeField]
    public  Transform centerbackground;

    public void Update()
    {
        if(transform.position.y >= centerbackground.position.y+ 19.61f){
            centerbackground.position = new Vector2(centerbackground.position.x, transform.position.y + 19.61f);
        }
        else if(transform.position.y <= centerbackground.position.y -19.61f)
        {
            centerbackground.position = new Vector2(centerbackground.position.x, transform.position.y - 19.61f);
        }
    }
}
