using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float speed = 2;
    public float GameSpeed = 2;
    private float movement = 0f;
    private float jump = 0f;
    private bool IsPressed = false;
    private Rigidbody2D rigidbody;
    private Animator playerAnimation;
    // Start is called before the first frame update
    void Start()
    {
       rigidbody = GetComponent<Rigidbody2D> ();
       playerAnimation = GetComponent<Animator> ();     
        rigidbody.velocity = new Vector2(GameSpeed,0);
           
    }

    // Update is called once per frame
    void Update()
    {
       jump = Input.GetAxis("Jump");

       if(jump > 0){
           playerAnimation.SetBool("IsJumpClicked",true);
           rigidbody.velocity = new Vector2(rigidbody.velocity.x,speed);
             
        }
       else{
           playerAnimation.SetBool("IsJumpClicked",false);
           
           rigidbody.velocity = new Vector2(rigidbody.velocity.x,0);
            
       }
        Debug.Log(rigidbody.position.x);

        if(Time.frameCount % 500 == 0){
            playerAnimation.SetBool("IsHealthy",false);
        }
        //Debug.Log("move-key");
    }
}
