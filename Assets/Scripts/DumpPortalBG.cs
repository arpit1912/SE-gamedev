using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DumpPortalBG : MonoBehaviour
{
    public Image bg;
    // Start is called before the first frame update
    void Start()
    {
        
        if(TypeController.getType() == 0)
        {
            bg.color = new Color32(255,0,0,78);
            return;
        }
        else if(TypeController.getType() == 1)
        {
            bg.color = new Color32(255,0,0,40);
            return;
        }
        else if(TypeController.getType() == 2)
        {
            bg.color = new Color32(255,255,0,78);
            return;
        }
        else if(TypeController.getType() == 3)
        {
            bg.color = new Color32(0,114,0,78);
            return;
        }
        else if(TypeController.getType() == 4)
        {
            bg.color = new Color32(145,145,145,78);
            return;
        }
        else if(TypeController.getType() == 5)
        {
            bg.color = new Color32(53,203,229,78);
            return;
        }
        else if(TypeController.getType() == 6)
        {
            bg.color = new Color32(229,119,0,110);
            return;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
