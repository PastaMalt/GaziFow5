using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SphereGenerator : MonoBehaviour
{
    public GameObject spherePrf;
    public int sayi = 0;

    void Start()
    {
        for (int i = 0; i < sayi; i++)
        {
            Vector3 pos = new Vector3(Random.Range(-50f, 50f), Random.Range(1f, 30f), Random.Range(-50f, 50f));

            GameObject sphere = Instantiate(spherePrf, pos, Quaternion.identity);
            spherePrf.tag = "Balon";

        }
    }
}
