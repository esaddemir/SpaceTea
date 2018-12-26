using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comets2 : MonoBehaviour
{
    private float rotateSpeed;
    void Start()
    {
        rotateSpeed = 75f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Time.deltaTime * rotateSpeed,0f ,0f );
    }
}
