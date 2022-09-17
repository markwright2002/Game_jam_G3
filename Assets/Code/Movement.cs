using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
public Rigidbody2D rb;
public Vector2 vec;
public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        vec.x = Input.GetAxis("Horizontal");
        vec.y = Input.GetAxis("Vertical");
        
        
        
       //transform.position += (Vector3) vec * speed * Time.deltaTime;
       
       
       //rb.AddForce(vec * speed); 
    }
}
