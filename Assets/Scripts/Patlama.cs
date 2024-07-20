using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Patlama : MonoBehaviour
{
  
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Balon")
        {

            Destroy(gameObject);
            Destroy(other.gameObject);

            GameObject go = GameObject.Find("Canvas");
            ScoreManager asd = go.GetComponent<ScoreManager>();
            asd.Skor();

            Debug.Log("trigger");
        }
       
    }

}
