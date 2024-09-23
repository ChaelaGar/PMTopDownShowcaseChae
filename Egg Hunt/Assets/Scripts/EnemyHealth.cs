using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField]
    float enemyHealth = 20;
    float maxeHP;
   Image healthBar;
    // Start is called before the first frame update
    void Start()
    {
        maxeHP = enemyHealth;
        healthBar = GetComponentsInChildren<Image>()[1];
    }

    // Update is called once per frame
    void Update()
    {
      healthBar.fillAmount = enemyHealth / maxeHP;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerBullet") 
        {

            enemyHealth -= 1;
            healthBar.fillAmount = enemyHealth / maxeHP;
            if (enemyHealth <= 0)
            {

              Destroy(gameObject);
            }
        }
    }
}

