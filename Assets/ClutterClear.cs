using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClutterClear : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if(collisionInfo.collider.tag == "bullet"){
            Destroy(collisionInfo.collider.gameObject);
        }
    }

 }
