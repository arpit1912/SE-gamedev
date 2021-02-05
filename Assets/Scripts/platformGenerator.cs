using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

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
    
    public GameObject Portal;
    public int FreqOfPortal;
    private int spikeSelector;
    Vector3[] spikePosition;
    private  int CurrentCount;
    private float time;
    private Scene scene;

    private void Awake()
    {
        CurrentCount = 1;
    }

    // Start is called before the first frame update
    void Start()
    {
        //oldplatformWidth = 4;
        //platformWidth = thePlatform.GetComponent<BoxCollider2D>().size.x;
        platformWidths = new float[thePlatforms.Length];
        FreqOfPortal = 5;
        CurrentCount = 1;
        time = 0f;
        Debug.Log("Called Each time!");
        for(int i = 0; i<thePlatforms.Length; i++){
            platformWidths[i] = thePlatforms[i].GetComponent<BoxCollider2D>().size.x;
        }

        scene = SceneManager.GetActiveScene();
        spikePosition = new Vector3[theSpikes.Length];
        spikePosition[0] = new Vector3(0f, 0.84f , -1f);
        spikePosition[1] = new Vector3(0f, -4.4f , -1f);
        spikePosition[2] = new Vector3(0f, 0.2f , -1f);
        spikePosition[3] = new Vector3(0f, 0f , -1f);

    } 

    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.x < generationPoint.position.x ){

            if (Time.unscaledTime - time > 1f)
            {
                Debug.Log("Invokes here!");
                CurrentCount++;
                time = Time.unscaledTime;
            }

            //distanceBetween = Random.Range(distanceBetweenMin, distanceBetweenMax);

            platformSelector = Random.Range(0, thePlatforms.Length);

            //transform.position = new Vector3(transform.position.x + (platformWidths[platformSelector]/2) + (oldplatformWidth/2) + distanceBetween, transform.position.y, transform.position.z);
            //oldplatformWidth = platformWidths[platformSelector];

            transform.position = new Vector3(transform.position.x + (platformWidths[platformSelector]/2) , transform.position.y, transform.position.z);

            
            if(CurrentCount % FreqOfPortal == 0){ // essentially means to make the gate after every FreqOfPortal times
                 
                    Debug.Log("Current count is = "+ CurrentCount + " FreqOfPortal is = " + FreqOfPortal);
                    
                    Vector3 GateLocation = new Vector3(2f,2.5f + Random.Range(0f,5f),-1f);
                    Instantiate(Portal,transform.position + GateLocation,transform.rotation);
                    CurrentCount = 1;
                    //CurrentCount = 0;
            }
            else{
                    if(Random.Range(0f, 100f) < randomSpikeThreshold){
                 
                        //Vector3 spikePosition = new Vector3(0f, 0.84f , -1f);
                        if(randomSpikeThreshold < 100){
                            randomSpikeThreshold += 1f;
                        }

                        Vector3 newSpikeposition = new Vector3(Random.Range(5f, 9.5f), 0f, 0f);
                        spikeSelector = Random.Range(0, theSpikes.Length);
                        Instantiate (theSpikes[spikeSelector], transform.position + spikePosition[spikeSelector] + newSpikeposition, transform.rotation );

                        newSpikeposition = new Vector3(Random.Range(9.5f, 14f), 0f, 0f);
                        spikeSelector = Random.Range(0, theSpikes.Length);
                        Instantiate (theSpikes[spikeSelector], transform.position + spikePosition[spikeSelector] - newSpikeposition, transform.rotation );
                    }
            } 
            Instantiate (thePlatforms[platformSelector], transform.position, transform.rotation);
            GameObject.DontDestroyOnLoad(thePlatforms[platformSelector]);
            transform.position = new Vector3(transform.position.x + (platformWidths[platformSelector]/2) , transform.position.y, transform.position.z);
            
        }

        
    }
}
