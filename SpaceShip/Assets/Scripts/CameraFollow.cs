using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    public Transform targetToFollow;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
            transform.position.x, //Mathf.Clamp(targetToFollow.position.y, 0f, 10f),
            targetToFollow.position.y +3,
            transform.position.z);
        
    }
}
