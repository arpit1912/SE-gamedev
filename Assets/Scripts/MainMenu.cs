using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public float tranistionTime = 1f;
    public void PlayGame ()
    {
        LoadNextLevel();
        //SceneManager.LoadScene("transition scene");
        
        Time.timeScale = 1f;
         //StartCoroutine(PlayGames());
         
    }

    private void Start()
    {
        PlayerPrefs.SetInt("Score",0);
        PlayerPrefs.SetFloat("health",100);
        //Debug.Log("this is the health: "+PlayerPrefs.GetFloat("health"));
        PlayerPrefs.SetFloat("jetpack",100);
        Debug.Log("this is the jetpack: "+PlayerPrefs.GetFloat("jetpack"));

    }

    public Animator transition;
    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel());
    }

    IEnumerator LoadLevel()
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(1);
        
        SceneManager.LoadScene("transition scene");
    }
    
    // IEnumerator PlayGames()
    // { 
    //     transition.SetTrigger("start");
    //     Debug.Log("kk");
    //     yield return new WaitForSeconds(3);
    //     SceneManager.LoadScene("mainScene");
        
    // }

    public void QuitGame ()
    {
        Debug.Log("quit game");
        Application.Quit();
    }


}

