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
    }
    public void Die()
    {
        gameObject.SetActive(false);
    }
}
