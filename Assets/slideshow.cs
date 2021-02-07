using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
 
public class slideshow : MonoBehaviour
{
   
//    var imageArray : Texture[];
//    var currentImage : int;
//    var imageRect : Rect;
//    var buttonRect : Rect;
 
    public Texture[] imageArray;
    private int currentImage;
    public GUIStyle customButton;
    //private Rect imageRect;
    //private Rect buttonRect;
   
 
   
    void OnGUI()
    {
       
        int w = Screen.width, h = Screen.height;
       
        //Rect imageRect = new Rect (0, 0, w, h * 2 / 100);
        Rect imageRect = new Rect(0, -1.5f, Screen.width + 10, Screen.height + 10);
        Rect buttonRect = new Rect(0, Screen.height - Screen.height / 12, Screen.width/2, Screen.height / 12);
        Rect buttonRect2 = new Rect(Screen.width/2, Screen.height - Screen.height / 12, Screen.width/2 , Screen.height / 12);

        if (currentImage >= imageArray.Length)
        {
            SceneManager.LoadScene("menuScene");
            return;
        }
            
   // GUI.Label(guiRect, imageArray[currentImage]);
        GUI.Label(imageRect, imageArray[currentImage], customButton);
   
        if(GUI.Button(buttonRect, "Menu"))
            SceneManager.LoadScene("menuScene");

        if((GUI.Button(buttonRect2, "Next")))
            currentImage++;
        
       
        
    }
    // Start is called before the first frame update
    void Start()
    {
        currentImage = 0;
    //    imageRect = Rect(0, 0, Screen.width, Screen.height);
//        buttonRect = Rect(0, Screen.height - Screen.height / 10, Screen.width, Screen.height / 10);
    }
 
    // Update is called once per frame
    void Update()
    {
       
    }
}