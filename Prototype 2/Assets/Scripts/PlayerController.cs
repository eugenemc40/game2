using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;//moves player left to right
    public float speed = 10.0f;//player speed
    public float xRange =10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if statements to ensureplayer to stay in range
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y,transform.position.z);
        }
        if (transform.position.x < xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }



        //updates payer movement 
        horizontalInput = Input.GetAxis("Horizontal");

        //updates movement to player based on time and speed
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

    }
}
