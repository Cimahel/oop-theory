using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(this);
    }

    public void StartScene()
    {
        SceneManager.LoadScene("Main");
    }

    public void QUit()
    {
        Application.Quit();
    }
    
}
