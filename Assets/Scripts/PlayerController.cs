using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public Animator transition;
    public static PlayerController Instance = null;
    private float speed = 10;
    private float GameSpeed = 8;
    private float movement = 0f;
    private float jump = 0f;
    private bool IsPressed = false;
    private Rigidbody2D rigidbody;
    private Animator playerAnimation;
    public Transform groundCheckPoint;
    public float groundCheckRadius;
    public LayerMask groundLayer;
    private bool isTouchingGround;
    public HealthBar healthbar;
    public JetpackPower jetpackbar;
    public static bool isDead;
    private bool HaveFuel;

    void Start()
    {
        isDead = false;
        HaveFuel = true;
        playerAnimation = GetComponent<Animator>();
        if (Instance != null)
        {
            //Debug.Log("Object Already exist");


            GameObject go = GameObject.Find("player_sprite");
            Vector3 pos = go.transform.position;
            pos.x = PlayerPrefs.GetFloat("playerX");
            pos.y = 9.0f;
            go.transform.position = pos;
            Destroy(this.gameObject);
            return;
        }

        Instance = this;
        //Debug.Log("Hello");

        GameObject.DontDestroyOnLoad(this.gameObject);
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.velocity = new Vector2(GameSpeed, 0);
        //rigidbody.AddForce(new Vector2(5,-1));
    }

    // Update is called once per frame
    void Update()
    {
        jump = Input.GetAxis("Jump");
        isTouchingGround = Physics2D.OverlapCircle(groundCheckPoint.position, groundCheckRadius, groundLayer);
//       Debug.Log(isTouchingGround);
        playerAnimation.SetBool("OnGround", isTouchingGround);
        if (HaveFuel && jump > 0)
        {
            rigidbody.velocity = new Vector2(GameSpeed, speed);
        }
        else if (!isDead)
        {
            rigidbody.velocity = new Vector2(GameSpeed, -speed + 4);
        }

        if (healthbar.slider.value < 1f)
        {
            isDead = true;
            Debug.Log("player died");
            playerAnimation.SetBool("isAlive", false);
        }

        if (jetpackbar.slider.value < 1f)
        {
            HaveFuel = false;
            playerAnimation.SetBool("HaveFuel", false);
            Debug.Log("No fuel left in the back");
        }

        if (isDead)
        {
            if (rigidbody.velocity.x > 0)
            {
                rigidbody.AddForce(new Vector2(-5, -1));
            }
            else
            {
                rigidbody.velocity = new Vector2(0, -2);
                gameObject.GetComponent<PolygonCollider2D>().enabled = false;
                LoadNextLevel();
            }
        }
    }


    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel());
    }

    IEnumerator LoadLevel()
    {
        yield return new WaitForSeconds(2);
        transition.SetTrigger("ChangeScene");

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene("DeathScene");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("obstacles"))
        {
            healthbar.DealtDamage(5f);
        }
    }
}