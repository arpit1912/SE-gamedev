using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
	public float currentHealth;
	public Slider slider;
	public Gradient gradient;
	public Image fill;
	public float factor;
	public float time;
	public void SetMaxHealth(float health)
	{
		slider.maxValue = 100f;
		slider.value = health;

		fill.color = gradient.Evaluate(1f);
	}
	
    public void SetHealth(float health)
	{
		slider.value = health;

		fill.color = gradient.Evaluate(slider.normalizedValue);
	}

    private void Start()
    {
	    factor = 1;
	    time = Time.time;
    }

    private void Update()
    {
	    if (Time.time - time > 10)
	    {
		    factor = factor * 2;
		    time = Time.time;
	    }
    }

    public void DealtDamage(float damage)
    {
	    slider.value -= factor*damage;
	    fill.color = gradient.Evaluate(slider.normalizedValue);
    }

}
