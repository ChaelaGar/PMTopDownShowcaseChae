using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChase : MonoBehaviour
{
    [SerializeField]
    float chaseSpeed = 1.0f;
    GameObject player;
    [SerializeField]
    float chasedis = 20.0f;
    [SerializeField]
    bool homepoint = true;
    [SerializeField]
    Vector3 homePos;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        Vector3 homePos = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        //The chase direction is destination - enemy starting position
        Vector3 playerPosition = player.transform.position;
        Vector3 chaseDir = playerPosition - transform.position;
        Vector3 homedir = homePos - transform.position;
        //move towards player
        if (chaseDir.magnitude < chasedis)
        {
            chaseDir.Normalize();
            GetComponent<Rigidbody2D>().velocity = chaseDir * chaseSpeed;
        }
        else if (homepoint == true)
        {
        if (homedir.magnitude < 1.0f)

                    homedir.Normalize();
            GetComponent<Rigidbody2D>().velocity = homedir * chaseSpeed;
        }
        
         
    
           

        
        else
        {
            GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        }






    }
    
}
