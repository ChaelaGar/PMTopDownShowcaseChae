using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausemenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Canvas>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //If ESC 
        if (Input.GetKeyDown(KeyCode.Escape) && Time.timeScale == 1)
        {
            //display pause menu
            GetComponent<Canvas>().enabled = true;
            //Pause game
            Time.timeScale = 0;

        }
        else if (Input.GetKeyDown(KeyCode.Escape) && Time.timeScale == 0) {
     
              Resume();


        }
      
    }

    public void Resume()
    {
        //hide canvas
        GetComponent<Canvas>().enabled = false;
        //set timescale to 1
        Time.timeScale = 1;
    }

    public void Reload()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
