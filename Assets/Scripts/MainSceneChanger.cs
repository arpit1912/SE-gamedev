using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainSceneChanger : MonoBehaviour
{
    public static bool sceneChangeOccurred;
    // Start is called before the first frame update
    void Start()
    {
        //sceneChangeOccurred = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter2D(Collider2D other){
        GameObject go = GameObject.Find("player_sprite");
        Destroy(GameObject.Find("DoorLocked"));
        sceneChangeOccurred = true;
        Debug.Log("Triggered");
        PlayerPrefs.SetFloat("playerY",4f);
        PlayerPrefs.SetFloat("playerX",go.transform.position.x);
        SceneManager.LoadScene("DumpPortalScene");

    }
}
