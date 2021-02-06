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
		currentHealth = maxHealth;
		healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
	    
		//ContinuosDamage();
    }

    void ContinuosDamage()
    {
	    TakeDamage(0.5f);
    }
	void TakeDamage(float damage)
	{
		currentHealth -= damage;

		healthBar.SetHealth(currentHealth);
	}
}
