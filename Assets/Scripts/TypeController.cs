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
        Categories = 7;
        type = Random.Range(0, Categories); // Define the max based on the type of waste we have 

        bool found = false;
        int sizecheck = 0;
        while (!found && sizecheck < 100)
        {
            for (int i = 0; i < buttonTemplate.Length; i++)
            {
                if (buttonTemplate[i].CompareTag(numberToTag[type]) && (PlayerPrefs.GetInt(buttonTemplate[i].name) != 0))
                {
                
                    found = true;
                    Debug.Log("It works !! this type is present!");
                    break;
                }
            }

            type++;
            type = type % 7;
            sizecheck++;
        }

        if (!found)
        {
            Debug.Log("Type not found");
        }
        Debug.Log("Type is " + type);
    }

    public static int getType()
    {
        
        Debug.Log("Type returned is "+type);
        return type;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
