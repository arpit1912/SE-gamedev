using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance = null;
    private float speed = 10;
    private float GameSpeed = 8;
    private float movement = 0f;
    private float jump = 0f;
    private bool IsPressed = false;
    private Rigidbody2D rigidbody;
    
    void Start()
    {
       
       if (Instance != null)
       {
           
           Debug.Log("Object Already exist");
           
           Destroy(this.gameObject);
           
           GameObject go = GameObject.Find("player_sprite");
           Vector3 pos = go.transform.position;
           pos.x = PlayerPrefs.GetFloat("playerX");
           pos.y = PlayerPrefs.GetFloat("playerY");
           go.transform.position = pos;
           return;
       }

       Instance = this;
       Debug.Log("Hello");
       GameObject.DontDestroyOnLoad(this.gameObject);
       rigidbody = GetComponent<Rigidbody2D> ();
       rigidbody.velocity = new Vector2(GameSpeed,0);
    }

    // Update is called once per frame
    void Update()
    {
       jump = Input.GetAxis("Jump");

       if(jump > 0){
           //playerAnimation.SetBool("IsJumpClicked",true);
           rigidbody.velocity = new Vector2(GameSpeed,speed);
             
        }
       else{
           //playerAnimation.SetBool("IsJumpClicked",false);
           
           rigidbody.velocity = new Vector2(GameSpeed,-speed + 4);
            
       }
       // Debug.Log(Time.frameCount);

        // if(Time.frameCount % 500 == 0){
        //     playerAnimation.SetBool("IsHealthy",false);
        // }
        //Debug.Log("move-key");
    }
}
