using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaxScore : MonoBehaviour
{
    public int Score_Player;
    public int Max_Score;
    public GameObject Panel;
    public Text txtMaxScore;
    public Text txt;
   
   

    // Use this for initialization
    void Start()
    {
        Max_Score = PlayerPrefs.GetInt("MaxScore");
    }

    // Update is called once per frame
    void Update()
    {txt.text = "Score: " + Score_Player;
        if (Max_Score < Score_Player)
        {
            Max_Score = Score_Player;
            PlayerPrefs.SetInt("MaxScore", Max_Score);
        }
       
    
        else
        {
           // Panel.SetActive(true);
            txtMaxScore.text = "Max Score = " + Max_Score;
        }
    }
}
