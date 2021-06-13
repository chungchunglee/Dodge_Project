using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public Rigidbody playerRigidbody; // 이동에 사용할 RigidBody Component
    public float speed = 8f; 

    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        /* This is first Controll Code
        if(Input.GetKey(KeyCode.UpArrow)==true)
        {
            playerRigidbody.AddForce(0f, 0f, speed);
        }
        if(Input.GetKey(KeyCode.DownArrow)==true)
        {
            playerRigidbody.AddForce(0f, 0f, -speed);
        }
        if(Input.GetKey(KeyCode.RightArrow)==true)
        {
            playerRigidbody.AddForce(speed, 0f, 0f);
        }
        if(Input.GetKey(KeyCode.LeftArrow)==true)
        {
            playerRigidbody.AddForce(-speed, 0f, 0f);
        }
        */
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        Vector3 newVelocity = new Vector3(xSpeed, 0, zSpeed);
        playerRigidbody.velocity = newVelocity;

    }
    public void Die()
    {
        gameObject.SetActive(false);
    }
}
