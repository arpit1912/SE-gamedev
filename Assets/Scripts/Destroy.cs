using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    // 0 signifies for bio-degradable waste
    // 1 signifies for the electronic waste
    // 2 metal
    // 3 glass 
    // 4 charge
    // 5 plastic
    void Start()
    {
        var button = transform.GetComponent<Button>();

        button.onClick.AddListener(delegate()
        {
            
            if((TypeController.getType() == 0) &&  gameObject.CompareTag("bio-degradable"))
            {
                Destroy(this.gameObject);
                Debug.Log("This is bio-degradable waste");
                return;
            }
            else if ((TypeController.getType() == 1) &&  gameObject.CompareTag("electronic"))
            {
                Destroy(this.gameObject);
                Debug.Log("This is elctronic waste");
                return;
            }
            else if((TypeController.getType() == 2) &&  gameObject.CompareTag("metal"))
            {
                Destroy(this.gameObject);
                Debug.Log("This is Metallic waste");
                return;
            }
            else if((TypeController.getType() == 3) &&  gameObject.CompareTag("glass"))
            {
                Destroy(this.gameObject);
                Debug.Log("This is Glasss waste");
                return;
            }
            else if((TypeController.getType() == 4) &&  gameObject.CompareTag("charge"))
            {
                Destroy(this.gameObject);
                Debug.Log("This is the charge up!!");
                return;
            }
            else if((TypeController.getType() == 5) &&  gameObject.CompareTag("plastic"))
            {
                Destroy(this.gameObject);
                Debug.Log("This is plastic waste");
                return;
            }
        });
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    
}
