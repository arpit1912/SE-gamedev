using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddCollectable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        int temp = PlayerPrefs.GetInt(this.gameObject.name.Split('(')[0]);
        
        //Debug.Log(this.gameObject.name.Split('(')[0] + " " + temp.ToString() + " " + (temp+1).ToString());
        temp++;
        PlayerPrefs.SetInt(this.gameObject.name.Split('(')[0],temp);
        Destroy(this.gameObject);
    }
}
