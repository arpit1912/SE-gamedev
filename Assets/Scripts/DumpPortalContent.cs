using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class DumpPortalContent : MonoBehaviour
{
    public TextMeshProUGUI content;
    private string[] contents = {
        "Almost all e-wastes contain some form of recyclable material, including glass and metals. They require chemical traetment to remove toxic substances first though, hence seperate disposal.",
        "While its fine to throw away regular non-rechargable batteries in household trash, only do so once they're discharged. ",
        "Glass can be completely recycled! So make sure to do your part by seperating glass products for recycling.",
        "Organic waste can be used for a variety of things, including composting, as lifestock feed or to produce fuel.",
        "Paper too can be recycled, which means saving tons of trees, water and other natural resources.",
        "Metal recycling is important, as our natural resources are limited.",
        "Some plastics can't be recycled and are causing hosts of problems to life everywhere, from mountains to seas."
    };

    private string[] contents2 = {
        "Quick, do your part and our advanced e-waste disposer will use the recycled materials to repair your suit.",
        "Rechargable batteries contain hazardous waste, and have to be disposed seperately.",
        "Here we will use the glass waste you collected to make you a new visor for better protection!",
        "We will use biomethanation to convert waste into biogas which powers your suit.",
        "Sadly, paper here has been contaminated. We'll use incineration to dispose it to ensure it does you no further damage.",
        "We will remould metal you choose to build and replace damaged parts of your suit",
        "Sadly that's the plastic we have here. Hopefully you'll reduce plastic after learning this",
    };

    void Start()
    {
        //content = gameObject.GetComponent<TextMeshProUGUI>();
        content.text = contents[TypeController.getType()] + System.Environment.NewLine + contents2[TypeController.getType()];
        //content.text = contents[6] + System.Environment.NewLine + contents2[6];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
