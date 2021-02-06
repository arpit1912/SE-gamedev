using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
public Animator transition;

    public void PlayGame ()
    {
        SceneManager.LoadScene("mainScene");
        Time.timeScale = 1f;
         //StartCoroutine(PlayGames());
         
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

