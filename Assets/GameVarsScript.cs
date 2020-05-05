using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameVarsScript : MonoBehaviour
{
    public Text hiscoreTxt;

    // Start is called before the first frame update
    private void Awake()
    {
        if(!PlayerPrefs.HasKey("HiScore"))
        {
            PlayerPrefs.SetInt("HiScore", 0);
        }
    }

    void Start()
    {
        PlayerPrefs.SetInt("Score", 0);
        PlayerPrefs.SetInt("Enemy01score", 100);

        hiscoreTxt.text = PlayerPrefs.GetInt("HiScore").ToString();
        
    }
}
