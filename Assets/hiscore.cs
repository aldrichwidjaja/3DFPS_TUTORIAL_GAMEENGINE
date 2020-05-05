using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hiscore : MonoBehaviour
{
    public Text scorescore;
    int score1;
    int score2;

    // Start is called before the first frame update
    void Start()
    {
        score1 = PlayerPrefs.GetInt("Score");
        scorescore.text = score1.ToString();
        score2 = PlayerPrefs.GetInt("HiScore");

        if (score1 > score2)
        {
            PlayerPrefs.SetInt("HiScore", score1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
