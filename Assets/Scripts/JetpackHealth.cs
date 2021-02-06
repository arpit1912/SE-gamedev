using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JetpackHealth : MonoBehaviour
{
    //public float maxHealth = 100;
	//private float currentHealth;
	public float currentFactor;
	public JetpackPower jetpackbar;
	public int LevelUpTime = 8;
	public float time;
    // Start is called before the first frame update
    void Start()
    {
	    time = Time.time;
	    currentFactor = 0.01f;
	    Debug.Log("This is the jetpack bar "+jetpackbar.slider.value);
		jetpackbar.SetHealth(PlayerPrefs.GetFloat("jetpack"));
		//jetpackbar.SetHealth(100);	// only for debugging purposes
    }

    private void OnDestroy()
    {
	    PlayerPrefs.SetFloat("jetpack",jetpackbar.slider.value);
    }

    // Update is called once per frame
    void Update()
    {
	    if (Time.time - time > LevelUpTime)
	    {
		    currentFactor += currentFactor;
		    time = Time.time;
	    }
	    
	    if (Input.GetKeyDown(KeyCode.Space))
	    {
		    TakeDamage(5*currentFactor);
		    return;
	    }
	    TakeDamage(currentFactor); 
		
    }

	void TakeDamage(float factor)
	{

		if (jetpackbar.slider.value < 0)
		{
			jetpackbar.slider.value = 0;
			return;
		}
			
		jetpackbar.slider.value -= factor;
		jetpackbar.SetHealth(jetpackbar.slider.value);
	}
}
