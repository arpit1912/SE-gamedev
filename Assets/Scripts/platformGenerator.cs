using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformGenerator : MonoBehaviour
{
    //public GameObject thePlatform;
    public GameObject[] thePlatforms;
    public Transform generationPoint;
    public float distanceBetween;

    //private float platformWidth;

    public float distanceBetweenMin, distanceBetweenMax;

    private int platformSelector;
    private float[] platformWidths;
    private float oldplatformWidth;

    // Start is called before the first frame update
    void Start()
    {
        oldplatformWidth = 4;
        //platformWidth = thePlatform.GetComponent<BoxCollider2D>().size.x;
        platformWidths = new float[thePlatforms.Length];

        for(int i = 0; i<thePlatforms.Length; i++){
            platformWidths[i] = thePlatforms[i].GetComponent<BoxCollider2D>().size.x;
        }
    } 

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < generationPoint.position.x ){

            distanceBetween = Random.Range(distanceBetweenMin, distanceBetweenMax);

            platformSelector = Random.Range(0, thePlatforms.Length);

            transform.position = new Vector3(transform.position.x + (platformWidths[platformSelector]/2) + (oldplatformWidth/2) + distanceBetween, transform.position.y, transform.position.z);
            oldplatformWidth = platformWidths[platformSelector];
            Instantiate (thePlatforms[platformSelector], transform.position, transform.rotation);
        }
    }
}
