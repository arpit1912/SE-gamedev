using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformGenerator : MonoBehaviour
{
    //public GameObject thePlatform;
    public GameObject[] thePlatforms;
    public Transform generationPoint;
    //public float distanceBetween;

    //private float platformWidth;

    //public float distanceBetweenMin, distanceBetweenMax;

    private int platformSelector;
    private float[] platformWidths;
    //private float oldplatformWidth;

    public float randomSpikeThreshold;
    public GameObject[] theSpikes;
    private int spikeSelector;
    Vector3[] spikePosition;
    
    // Start is called before the first frame update
    void Start()
    {
        //oldplatformWidth = 4;
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

            //distanceBetween = Random.Range(distanceBetweenMin, distanceBetweenMax);

            platformSelector = Random.Range(0, thePlatforms.Length);

            //transform.position = new Vector3(transform.position.x + (platformWidths[platformSelector]/2) + (oldplatformWidth/2) + distanceBetween, transform.position.y, transform.position.z);
            //oldplatformWidth = platformWidths[platformSelector];

            transform.position = new Vector3(transform.position.x + 2*(platformWidths[platformSelector]/3) , transform.position.y, transform.position.z);

            spikePosition = new Vector3[theSpikes.Length];
            spikePosition[0] = new Vector3(2f, 0.84f , -1f);
            spikePosition[1] = new Vector3(0f, -4.4f , -1f);
            spikePosition[2] = new Vector3(0f, 9.8f , -1f);
            spikePosition[3] = new Vector3(0f, 0f , -1f);


            if(Random.Range(0f, 100f) < randomSpikeThreshold){
                //Vector3 spikePosition = new Vector3(0f, 0.84f , -1f);
                if(randomSpikeThreshold < 100){
                    randomSpikeThreshold += 1f;
                }
                spikeSelector = Random.Range(0, theSpikes.Length);
                Instantiate (theSpikes[spikeSelector], transform.position + spikePosition[spikeSelector], transform.rotation );
            }
            Instantiate (thePlatforms[platformSelector], transform.position, transform.rotation);
        
            
        }

        
    }
}
