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
    void Start()
    {
        var button = transform.GetComponent<Button>();

        button.onClick.AddListener(delegate()
        {
            Debug.Log(gameObject.tag + " " + TypeController.getType()) ;
            if((TypeController.getType() == 0) &&  gameObject.CompareTag("ewaste"))
            {
                Destroy(this.gameObject);
                Debug.Log("This is e-waste waste");
                return;
            }
            else if ((TypeController.getType() == 1) &&  gameObject.CompareTag("battery"))
            {
                Destroy(this.gameObject);
                Debug.Log("This is battery waste");
                return;
            }
            else if((TypeController.getType() == 2) &&  gameObject.CompareTag("glass"))
            {
                Destroy(this.gameObject);
                Debug.Log("This is glass waste");
                return;
            }
            else if((TypeController.getType() == 3) &&  gameObject.CompareTag("bio-degradable"))
            {
                Destroy(this.gameObject);
                Debug.Log("This is bio-degradable waste");
                return;
            }
            else if((TypeController.getType() == 4) &&  gameObject.CompareTag("paper"))
            {
                Destroy(this.gameObject);
                Debug.Log("This is the paper up!!");
                return;
            }
            else if((TypeController.getType() == 5) &&  gameObject.CompareTag("metal"))
            {
                Destroy(this.gameObject);
                Debug.Log("This is metal waste");
                return;
            }
            else if((TypeController.getType() == 6) &&  gameObject.CompareTag("plastic"))
            {
                Destroy(this.gameObject);
                Debug.Log("This is plastic waste");
                return;
            }
        });
    }
    public void updatehealth(float number){
        float current_health = PlayerPrefs.GetFloat("health");
        current_health += number;
        PlayerPrefs.SetFloat("health",current_health);
    }

    public void updatefuel(float number)
    {
        float current_fuel = PlayerPrefs.GetFloat("jetpack");
        current_fuel += number;
        PlayerPrefs.SetFloat("jetpack",current_fuel);

    }
    // Update is called once per frame
    void Update()
    {
       
    }
    
}
