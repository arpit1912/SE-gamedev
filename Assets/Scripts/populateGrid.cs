using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class populateGrid : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] wasteMaterial;  //array of wasteMaterial prefabs

    public int numberToCreate;  //number of objects to create
    void Start()
    {
        numberToCreate = wasteMaterial.Length;
        Populate();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Populate()
    {
        GameObject newObj;

        for(int i = 0; i < numberToCreate; i++)
        {
            newObj = (GameObject)Instantiate(wasteMaterial[i], transform);
        }
    }
} 
