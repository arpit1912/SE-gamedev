using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypeController : MonoBehaviour
{
    // Start is called before the first frame update
    private int Categories;
    private static int type;    // Anyone should not be able to change it as it will create a mess otherwise.
    public GameObject[] buttonTemplate;
    private Dictionary<int,string> numberToTag;
    private Dictionary<int, int> TagCount;
    void Awake()
    {
        numberToTag = new Dictionary<int, string>()
        {
            {0,"ewaste"},
            {1,"battery"},
            {2,"glass"},
            {3,"bio-degradable"},
            {4,"paper"},
            {5,"metal"},
            {6,"plastic"}
        };
        TagCount = new Dictionary<int, int>(){
            {0,0},
            {1,0},
            {2,0},
            {3,0},
            {4,0},
            {5,0},
            {6,0}
        };
        for (int i = 0; i < buttonTemplate.Length; i++)
        {
            if (buttonTemplate[i].CompareTag("ewaste"))
            {
                TagCount[0] += PlayerPrefs.GetInt(buttonTemplate[i].name);
            }
            if (buttonTemplate[i].CompareTag("battery"))
            {
                TagCount[1] += PlayerPrefs.GetInt(buttonTemplate[i].name);
            }
            if (buttonTemplate[i].CompareTag("glass"))
            {
                TagCount[2] += PlayerPrefs.GetInt(buttonTemplate[i].name);
            }
            if (buttonTemplate[i].CompareTag("bio-degradable"))
            {
                TagCount[3] += PlayerPrefs.GetInt(buttonTemplate[i].name);
            }
            if (buttonTemplate[i].CompareTag("paper"))
            {
                TagCount[4] += PlayerPrefs.GetInt(buttonTemplate[i].name);
            }
            if (buttonTemplate[i].CompareTag("metal"))
            {
                TagCount[5] += PlayerPrefs.GetInt(buttonTemplate[i].name);
            }
            if (buttonTemplate[i].CompareTag("plastic"))
            {
                TagCount[6] += PlayerPrefs.GetInt(buttonTemplate[i].name);
            }
        }

        
        Categories = 7;
        type = Random.Range(0, Categories); // Define the max based on the type of waste we have 
        int totalitems = 0;
        foreach (var variable in TagCount)
        {
            totalitems += variable.Value;
        }

        while ((totalitems > 0) && TagCount[type] == 0)
        {
            type++;
            if (type == 7)
            {
                type = 0;
            }
        }
        Debug.Log("Type is " + type);
    }

    public static int getType()
    {
        
       // Debug.Log("Type returned is "+type);
        return type;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
