using UnityEngine;
using System.Collections;
 

public class Floater : MonoBehaviour {
    // User Inputs
    private float[] amplitudes = {0.5f, -0.5f, 0.3f, -0.4f};
    public float frequency = 0.3f;
    private float[] angles = {0.25f, -0.2f, -0.25f, 0.2f};
    private int index;
    private float amplitude, angle;
    // Position Storage Variables
    Vector3 posOffset = new Vector3 ();
    Vector3 tempPos = new Vector3 ();
 
    // Use this for initialization
    void Start () {
        // Store the starting position & rotation of the object
        posOffset = transform.position;
        index = (int)Random.Range(0,4);
        amplitude = amplitudes[index];
        index = (int)Random.Range(0,4);
        angle = angles[index];
    }
     
    // Update is called once per frame
    void Update () {
        index = (int)Random.Range(0,4);
//        Debug.Log(index);
        transform.Rotate(Vector3.forward * angle);
        //transform.eulerAngles = Vector3.forward * degreesPerSecond;
        //index = (int)Random.Range(0,4);
        //Debug.Log(index);
        tempPos = posOffset;
        tempPos.y += Mathf.Sin (Time.fixedTime * Mathf.PI * frequency) * amplitude;
 
        transform.position = tempPos;
    }
}
