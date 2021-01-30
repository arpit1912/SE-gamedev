using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public float Offset;
    private Vector3 playerPosition;
    // Start is called before the first frame update
    public float offsetSmoothing;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerPosition = new Vector3(player.transform.position.x + Offset,transform.position.y,transform.position.z);
        transform.position =playerPosition;
    }
}
