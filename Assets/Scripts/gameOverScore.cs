using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameOverScore : MonoBehaviour
{
    public Text TextScore;
    public Text TextScoreHead;

    // Start is called before the first frame update
    void Start()
    {
       
        TextScore.text = "Yuor Score:     " + Mathf.Round(myText.mySore).ToString();
        TextScoreHead.text = "Score: " + Mathf.Round(myText.mySore).ToString();
    }
     
  
}
