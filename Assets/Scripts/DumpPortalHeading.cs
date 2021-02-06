using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DumpPortalHeading : MonoBehaviour
{
    public TextMeshProUGUI heading;
    public string[] headings = {
        "Select all e-waste items to repair damaged suit",
        "Click on batteries to get a quick power boost!",
        "Select glass products to repair damaged suit visor",
        "Select  all organic waste to fuel up your jetpack!",
        "Remove all paper waste to reduce corrosion damage",
        "Select metal items to repair jetpack and suit",
        "Eleminate all plastic waste before it's too late... "
    };

    void Start()
    {
        //heading = gameObject.GetComponent<TextMeshProUGUI>();
        heading.text = headings[TypeController.getType()];
        //heading.text = headings[2];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
