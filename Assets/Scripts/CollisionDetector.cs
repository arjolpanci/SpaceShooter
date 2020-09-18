using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if(collisionInfo.collider.tag == "asteroid"){
            Destroy(collisionInfo.gameObject);
            Destroy(this.gameObject);
        }   
    }

}
