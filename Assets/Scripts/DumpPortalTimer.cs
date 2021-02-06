using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DumpPortalTimer : MonoBehaviour
{
    public Transform LoadingBar;
    public Transform TextIndicator;
    [SerializeField] private float startTime;
    [SerializeField] private float display;
    private int timeinterval = 15;
    
    
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        display = timeinterval - (Time.time - startTime);
        Debug.Log (display);
        TextIndicator.GetComponent<Text>().text = ((int)display).ToString();
        LoadingBar.GetComponent<Image>().fillAmount =  (display/timeinterval);
    }
}
