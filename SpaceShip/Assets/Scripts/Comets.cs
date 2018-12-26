using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comets : MonoBehaviour
{
    private float rotateSpeed;
    void Start()
    {
        rotateSpeed = 80f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, Time.deltaTime * rotateSpeed);
    }
}
