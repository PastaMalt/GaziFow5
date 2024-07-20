using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Yaziyaz : MonoBehaviour
{
    public TMP_Text cikis;
    public TMP_InputField giris;
    int sayim = 0;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {      
           cikis.text = sayim.ToString();
           sayim++;
        }
    }
}
