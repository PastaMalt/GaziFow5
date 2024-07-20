using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip sesClip;
    private AudioSource sesKaynagi;
  
    void Start()
    {
        sesKaynagi = GetComponent<AudioSource>();
        sesKaynagi.clip = sesClip;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            sesKaynagi.Play();
        }
    }
}
