using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.VFX;

public class PlayerShoot : MonoBehaviour
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
    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime; //0.0166666666 = 60fps
        //On mouse click
        if (Input.GetButton("Fire1") && Timer > shootDelay)
        {
            Timer = 0; //reset timer
            //Shoot towards cursor
            Vector3 MousePos = Input.mousePosition;
            MousePos = Camera.main.ScreenToWorldPoint(MousePos);
            MousePos.z = 0;
            Vector3 mouseDir = MousePos - transform.position;
            //Normal vecky 
            mouseDir.Normalize();
            //spawn bull
            GameObject bullet = Instantiate(prefab, transform.position, Quaternion.identity);
            //Shoot the bullet towards the mouse
            bullet.GetComponent<Rigidbody2D>().velocity = mouseDir * Speedbull;
            Destroy(bullet, bulletlifetime);
        }
    }
}
