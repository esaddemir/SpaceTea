using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teaRespawn : MonoBehaviour
{
    [SerializeField]
    public Transform teaObject;
    public void Respawn()
    {
        teaObject.position = new Vector2(teaObject.position.x, teaObject.position.y + 10f);
    }


}
