using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject ConfirmationUI;
    void start(){ 
        //Canvas.SetActive (false);
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume(){
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause(){
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadConfirmationUI()
    {
        ConfirmationUI.SetActive(true);
    }

    public void ReturnBack()
    {
        ConfirmationUI.SetActive(false);
    }
    public void LoadMenu(){
        Debug.Log("load menu");
        SceneManager.LoadScene("menuScene");
    }

    public void QuitGame(){
        Debug.Log("quit game");
        Application.Quit();
    }
}
