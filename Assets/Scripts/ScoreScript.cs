using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public TextMeshProUGUI heading;

    private int score;
    private double time;
    private int factor;

    private int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        factor = 1;
        time = Time.time;

        score = PlayerPrefs.GetInt("Score");
        heading.text = "Score: "+ score.ToString();

        Debug.Log("this is the score: "+score);
    }

    private void OnDestroy()
    {
        
        PlayerPrefs.SetInt("Score",score);
    }

    // Update is called once per frame
    void Update()
    {
        if (!PlayerController.isDead)
        {
            count++;
            if (count == 20)
            {
                score = score + factor*1;
                count = 0;
            }
            
            if (Time.time - time > 6)
            {
                if (factor < 100)
                {
                    factor = 2 * factor;
                }
                
                time = Time.time;
            }
            heading.text = "Score: "+ score.ToString();
        }
        
    }
}