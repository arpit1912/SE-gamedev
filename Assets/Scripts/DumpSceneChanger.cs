using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DumpSceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var button = transform.GetComponent<Button>();

        button.onClick.AddListener(delegate()
        {
            SceneManager.LoadScene("mainScene");
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
