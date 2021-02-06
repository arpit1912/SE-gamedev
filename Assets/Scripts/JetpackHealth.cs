using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JetpackHealth : MonoBehaviour
{
    public float maxHealth = 100;
	public float currentHealth;
	public float currentFactor;
	public JetpackPower healthBar;
	public int LevelUpTime = 5;
	public float time;
    // Start is called before the first frame update
    void Start()
    {
	    time = Time.time;
	    currentFactor = 0.005f;
		currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);
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
		
		currentHealth -= factor;
		healthBar.SetHealth(currentHealth);
	}
}
