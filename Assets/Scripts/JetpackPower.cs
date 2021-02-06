using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JetpackPower : MonoBehaviour
{
    public Slider slider;
	public Gradient gradient;
	public Image fill;

	
	private void Start()
	{
		slider.maxValue = 100;
		fill.color = gradient.Evaluate(1f);
	}

	public void SetHealth(float health)
	{
		slider.value = health;

		fill.color = gradient.Evaluate(slider.normalizedValue);
	}
}
