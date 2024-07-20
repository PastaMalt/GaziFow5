using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mermi : MonoBehaviour
{
    public int hiz = 5;
    public GameObject arrow;

    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Mouse0))
       {
           GameObject mermi = Instantiate(arrow);

           mermi.transform.position = gameObject.transform.position;
           mermi.transform.rotation = gameObject.transform.rotation;

           Rigidbody rb = mermi.GetComponent<Rigidbody>();
           rb.AddForce(transform.forward * hiz, ForceMode.Impulse);
           rb.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;


           Patlama asd = mermi.AddComponent<Patlama>();
       }

        

        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            SceneManager.LoadScene("Scene4");
        }
    }


}
