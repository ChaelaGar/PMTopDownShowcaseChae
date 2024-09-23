using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]
    float MoveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        //check x y input
        //move play based on input
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");
        //velocity is vector2 varible, storing 2 floats, x and y.
        GetComponent<Rigidbody2D>().velocity = new Vector2(xInput, yInput) * MoveSpeed;
      
    }
}
