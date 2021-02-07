using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Addscore : MonoBehaviour
{
    public TextMeshProUGUI score;

    public Animator transition;
    // Start is called before the first frame update
    void Start()
    {
        score.text = "Your Score: " + PlayerPrefs.GetInt("Score").ToString();
        //LoadNextLevel();
    }
    public void LoadNextLevel()
    {
        Debug.Log("This is called");
        StartCoroutine(LoadLevel());
    }

    IEnumerator LoadLevel()
    {
        //yield return new WaitForSeconds(2);
        transition.SetTrigger("clicked");

        yield return new WaitForSeconds(1);

        SceneManager.LoadScene("menuScene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
