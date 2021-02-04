using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    // 0 signifies for bio-degradable waste
    // 1 signifies for the electron waste
    void Start()
    {
        var button = transform.GetComponent<Button>();

        button.onClick.AddListener(delegate()
        {
            if ((TypeController.getType() == 1) &&  gameObject.CompareTag("electronic"))
            {
                Destroy(this.gameObject);
                Debug.Log("This is elctronic waste");
            }
            else if((TypeController.getType() == 0) &&  gameObject.CompareTag("bio-degradable"))
            {
                Destroy(this.gameObject);
                Debug.Log("This is elctronic waste");
            }
            
        });
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    
}
