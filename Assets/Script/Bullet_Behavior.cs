using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Behavior : MonoBehaviour
{
    public float speed = 8f;
    private Rigidbody bulletRigidbody;

    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody>();
        bulletRigidbody.velocity = transform.forward * speed;
        Debug.Log("this is transform forward"+transform.forward);
        Destroy(gameObject, 3.0f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Player_Controller player_Controller = other.GetComponent<Player_Controller>();
            if(player_Controller != null)
            {
                player_Controller.Die();
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
