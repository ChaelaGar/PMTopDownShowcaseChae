using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyshoot : MonoBehaviour
{
    [SerializeField]
    GameObject prefab;
    [SerializeField]
    float Speedbull = 20f;
    [SerializeField]
    float bulletlifetime = 2.0f;
    float Timer = 0f;
    [SerializeField]
    float shootDelay = 0.5f;
    GameObject player;
    float ShootDistance = 5;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        //  if within range
        Vector3 shootDir = player.transform.position - transform.position;
        if (shootDir.magnitude < ShootDistance && Timer > shootDelay)
        {
            // shoot at player
            GameObject bullet = Instantiate(prefab, transform.position, Quaternion.identity);
            shootDir.Normalize();
            bullet.GetComponent<Rigidbody2D>().velocity = shootDir * Speedbull;
            // delay bullet
            Timer = 0;
            Destroy(bullet, bulletlifetime);

        }

        // shoot at player
        // delay bullet


    }
}
