using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypeController : MonoBehaviour
{
    // Start is called before the first frame update
    private int Categories;
    private static int type;    // Anyone should not be able to change it as it will create a mess otherwise.
    void Start()
    {
        Categories = 7;
        type = Random.Range(0, Categories);  // Define the max based on the type of waste we have 
        Debug.Log("Type is " + type);
    }

    public static int getType()
    {
        return type;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
