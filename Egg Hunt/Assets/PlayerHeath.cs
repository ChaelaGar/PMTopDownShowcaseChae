using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PlayerHeath : MonoBehaviour
{
    [SerializeField]

    float Health = 12;
    float MaxHp;
    string levelLoad = "lose";

    float timer = 0f;
    [SerializeField]
    float timerdelay = 0.5f;
 
    [SerializeField]
    Image healthBar;

    // Start is called before the first frame update
    void Start()
    {
        MaxHp = Health;
        healthBar.fillAmount = Health / MaxHp;
    }

    // Update is called once per frame
    void Update()
    {
     
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.tag == "Eneby" )
            Health -= 1;
        timer = 0f;
            Debug.Log(Health);
            //Consequences of your actions
            //Reload, try try again
            healthBar.fillAmount = Health / MaxHp;
            if (Health <= 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
               // SceneManager.LoadScene("levelLoad");
            }

        }
    private void OnTriggerEnter2D(Collider2D collision) 

    {
        if (collision.gameObject.tag == "Eneby")
            Health -= 1;
        timer = 0f;
        Debug.Log(Health);
        //Consequences of your actions
        //Reload, try try again
        healthBar.fillAmount = Health / MaxHp;
        if (Health <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            // SceneManager.LoadScene("levelLoad");
        }
    }




}
    



