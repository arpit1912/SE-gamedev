using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 10;
    private float GameSpeed = 8;
    private float movement = 0f;
    private float jump = 0f;
    private bool IsPressed = false;
    private Rigidbody2D rigidbody;
    //private Animator playerAnimation;
    // Start is called before the first frame update
    void Start()
    {
       rigidbody = GetComponent<Rigidbody2D> ();
       //playerAnimation = GetComponent<Animator> ();     
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
