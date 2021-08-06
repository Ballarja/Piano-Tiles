using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lastscore : MonoBehaviour
{

    public Text mytext;
    public static int scorepoints = 0;
   
    // Start is called before the first frame update
    void Start()
    {
        scorepoints = score.scorepoints;
        mytext.text = scorepoints.ToString("0");
        //lastscoere = FindObjectOfTypes<score>();
    }
    public void savescore(int scoree)
    {
        //lastscore += scoree;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
