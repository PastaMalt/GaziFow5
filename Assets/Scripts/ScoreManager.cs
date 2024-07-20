using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text scoreText;
    int scoreCount = 0;
    public void Skor()
    {
        scoreCount++;
        scoreText.text = scoreCount.ToString();    
    }
}
