using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadTheLevel()
    {
        SceneManager.LoadScene("Level 1");

    }
    public void exitapp() { 
    Application.Quit();
    }

}
