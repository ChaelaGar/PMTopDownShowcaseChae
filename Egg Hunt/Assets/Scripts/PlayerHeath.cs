using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class PlayerHeath : MonoBehaviour
{
   
   // public TextMeshProUGUI Scoretext;
    [SerializeField]

    float Health = 12;
    float MaxHp;
   // string levelLoad = "lose";

    float timer = 0f;
    [SerializeField]
    float timerDelay = 4f;
    [SerializeField]
    int Eggs = 0;
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
        timer += Time.deltaTime;
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if ((collision.gameObject.tag == "Enemy") && timer > timerDelay) { 

            Health -= 1;
        timer = 0;

        Debug.Log(Health);
        //Consequences of your actions
        //Reload, try try again
        healthBar.fillAmount = Health / MaxHp; }
       else if (Health <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            // SceneManager.LoadScene("levelLoad");
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        Debug.Log(collision.gameObject.name);
        if ((collision.gameObject.tag == "Enemy"))
        {
            Health -= 1;
            Debug.Log(Health);
            //Consequences of your actions
            //Reload, try try again
            healthBar.fillAmount = Health / MaxHp;
        }

        else if ((collision.gameObject.tag == "egg"))
        {
            Eggs += 1;
            Destroy(collision.gameObject);

        }
        else if ((collision.gameObject.tag == "wincon"))
        {
            SceneManager.LoadScene("Win");
        }
        if (Eggs >= 3)
        {
            SceneManager.LoadScene("Level 2");
        }


    }
}



