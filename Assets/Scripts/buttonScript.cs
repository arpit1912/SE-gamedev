﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Image myIcon;

    public void setIcon(Sprite mySprite){
        myIcon.sprite = mySprite;
    }
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
