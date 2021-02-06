using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

	public float maxHealth = 100;
	public float currentHealth;

	public HealthBar healthBar;
	
	private int time;
    // Start is called before the first frame update
    void Start()
    {
	    time = (int)Time.time ;
	    currentHealth = PlayerPrefs.GetFloat("health");
	    //currentHealth = 100;	// only for debugging pusposes
	    healthBar.SetHealth(currentHealth);
    }

    private void OnDestroy()
    {
	    Debug.Log("health bar :"+healthBar.slider.value);
	    PlayerPrefs.SetFloat("health",healthBar.slider.value);
    }

}
