using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

    private Rigidbody rb;
    public float speed;
    public float jumpForce;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate() {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        
        rb.AddForce (movement * speed);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
       

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collectable"))
        {
            other.gameObject.SetActive(false);
            RpcRespawn();
        }
    }

    void RpcRespawn()
    {
            // move back to zero location
            transform.position = new Vector3(0,50,0);
    }
}
