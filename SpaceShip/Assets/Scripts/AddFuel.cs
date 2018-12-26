using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddFuel : MonoBehaviour
{
   public Transform teaObject;
   
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name.Equals("Spaceship"))
        {
            SpaceShip.fuelAmount = 100;
            
            teaObject.position = new Vector2(teaObject.position.x, teaObject.position.y + 20f);
            

        }
    }
    
} 
