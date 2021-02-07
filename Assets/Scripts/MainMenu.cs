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
        PlayerPrefs.SetInt("battery",0);
        PlayerPrefs.SetInt("ewaste1",0);
        PlayerPrefs.SetInt("ewaste2",0);
        PlayerPrefs.SetInt("ewaste4",0);
        PlayerPrefs.SetInt("glass1",0);
        PlayerPrefs.SetInt("glass2",0);
        PlayerPrefs.SetInt("metal1",0);
        PlayerPrefs.SetInt("metal2",0);
        PlayerPrefs.SetInt("metal3",0);
        PlayerPrefs.SetInt("organic1",0);
        PlayerPrefs.SetInt("organic2",0);
        PlayerPrefs.SetInt("organic3",0);
        PlayerPrefs.SetInt("paper1",0);
        PlayerPrefs.SetInt("paper2",0);
        PlayerPrefs.SetInt("plastic1",0);
        PlayerPrefs.SetInt("plastic2",0);

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

