using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroy : MonoBehaviour
{
    // 7 categories 
    // Start is called before the first frame update
    // 0 ewaste
    // 1 battery
    // 2 glass
    // 3 organic - bio-degradable -
    // 4 paper
    // 5 metal
    // 6 plastic
    //public Shaker Shaker;
    void Start()
    {
        var button = transform.GetComponent<Button>();

        button.onClick.AddListener(delegate()
        {
            Debug.Log(gameObject.tag + " " + TypeController.getType()) ;
            if((TypeController.getType() == 0) &&  gameObject.CompareTag("ewaste"))
            {
                Destroy(this.gameObject);
                updatefuel(30);
                updatehealth(10);
                Debug.Log("This is e-waste waste");
                ReduceType(gameObject.name.Split('(')[0]);
                return;
            }
            else if ((TypeController.getType() == 1) &&  gameObject.CompareTag("battery"))
            {
                Destroy(this.gameObject);
                updatefuel(40);
                updatehealth(10);
                Debug.Log("This is battery waste");
                ReduceType(gameObject.name.Split('(')[0]);
                return;
            }
            else if((TypeController.getType() == 2) &&  gameObject.CompareTag("glass"))
            {
                Destroy(this.gameObject);
                updatefuel(40);
                updatehealth(10);
                Debug.Log("This is glass waste");
                ReduceType(gameObject.name.Split('(')[0]);
                return;
            }
            else if((TypeController.getType() == 3) &&  gameObject.CompareTag("bio-degradable"))
            {
                Destroy(this.gameObject);
                updatefuel(40);
                updatehealth(10);
                Debug.Log("This is bio-degradable waste");
                ReduceType(gameObject.name.Split('(')[0]);
                return;
            }
            else if((TypeController.getType() == 4) &&  gameObject.CompareTag("paper"))
            {
                Destroy(this.gameObject);
                updatefuel(40);
                updatehealth(10);
                Debug.Log("This is the paper up!!");
                ReduceType(gameObject.name.Split('(')[0]);
                return;
            }
            else if((TypeController.getType() == 5) &&  gameObject.CompareTag("metal"))
            {
                Destroy(this.gameObject);
                updatefuel(10);
                updatehealth(10);
                Debug.Log("This is metal waste");
                ReduceType(gameObject.name.Split('(')[0]);
                return;
            }
            else if((TypeController.getType() == 6) &&  gameObject.CompareTag("plastic"))
            {
                Destroy(this.gameObject);
                updatefuel(20);
                updatehealth(10);
                Debug.Log("This is plastic waste");
                ReduceType(gameObject.name.Split('(')[0]);
                return;
            }
            
            Shaker.instance.Shake(0.5f);
        });
    }
    public void updatehealth(float number){
        float current_health = PlayerPrefs.GetFloat("health");
        current_health += number;
        if (current_health > 100)
            current_health = 100;
        PlayerPrefs.SetFloat("health",current_health);
    }

    public void updatefuel(float number)
    {
        float current_fuel = PlayerPrefs.GetFloat("jetpack");
        current_fuel += number;
        Debug.Log(current_fuel);
        if (current_fuel > 100)
            current_fuel = 100;
        
        PlayerPrefs.SetFloat("jetpack",current_fuel);

    }

    public void ReduceType( string name)
    {
        int temp = PlayerPrefs.GetInt(name);
        Debug.Log("current it is "+ temp+ " for "+ name);
        temp--;
        if (temp < 0)
        {
            temp = 0;

        }
            
        Debug.Log(temp);
        
        PlayerPrefs.SetInt(name,temp);
    }
    // Update is called once per frame
    void Update()
    {
       
    }
    
}
