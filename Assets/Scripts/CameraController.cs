using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private GameObject player;
    public float Offset;
    private Vector3 playerPosition;
    // Start is called before the first frame update
    public float offsetSmoothing;
    void Start()
    {
        player = GameObject.Find("player_sprite");
        if (MainSceneChanger.sceneChangeOccurred)
        {
            Vector3 pos = player.transform.position;
            pos.x = PlayerPrefs.GetFloat("playerX");
            pos.y = PlayerPrefs.GetFloat("playerY");
            player.transform.position = pos;

            MainSceneChanger.sceneChangeOccurred = false;
        }
        Debug.Log("PLayer is active now");
    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log("Camera Set Position");
        playerPosition = new Vector3(player.transform.position.x + Offset,transform.position.y,transform.position.z);
        transform.position =playerPosition;
    }
}
