using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpForce = 5f;
    public bool ground = true;
    public Rigidbody rb;

    void Start()
    {
       rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && ground)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            ground = false;
            Debug.Log("zýpla");
        }
    }

    void OnCollisionEnter(Collision collision)
    {  
         if (collision.gameObject.CompareTag("Ground"))
         {
             ground = true;
              Debug.Log("yer");
         }
    }
   
}
