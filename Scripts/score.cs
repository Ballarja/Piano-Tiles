using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{

    public Text mytext;
    public static int scorepoints;
    public int scoree = 0;
    
    public void Scoreupdate(int score)
    {
        scoree += score;
        scorepoints = scoree;
        mytext.text = scorepoints.ToString("0");
    }
    
}
