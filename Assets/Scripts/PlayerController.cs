using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public GameObject bullet;
    public CharacterController playerController;
    public float playerSpeed;

    private Vector3 offset = new Vector3(0, 0.2F, 0);

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        moveX *= Time.deltaTime;

        playerController.Move(transform.right * moveX * playerSpeed);

        if(Input.GetKeyUp("space")){
            Instantiate(bullet, transform.position + offset, Quaternion.identity);
        }

    }
}
