using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
public class ButtonController : MonoBehaviour
{
   
    VideoPlayer player;
    Image img;
    public Sprite playsp;
    public Sprite pausesp;
    public Button bdbutton;

    void Start()
    {
        player = GetComponent<VideoPlayer>();
        img = bdbutton.GetComponent<Image>();

    }
    public void Baslat()
    {
        if (player.isPlaying)
        {
            player.Pause();
            img.sprite = playsp;
            Debug.Log("Duraklatýldý");
        }
        else if (!player.isPlaying)
        {
            player.Play();
            img.sprite = pausesp;
        }
    }

    public void Durdur()
    { 
        if (player != null)
        {
            player.Stop();
            player.frame = 0;
            Debug.Log("Durduruldu");
        }
        else
        {
            Debug.Log("error");
        }
    }

}

