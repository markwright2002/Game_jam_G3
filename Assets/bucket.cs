using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bucket : MonoBehaviour
{

    public Rigidbody2D rb;
    public Vector2 vec;
    public Vector3 vec3;
    public float speed;
    public float endl, endr;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vec.x = Input.GetAxis("Horizontal");


        

        transform.position += (Vector3) vec * speed * Time.deltaTime;

        if(transform.position[0] > endr){

            vec3 = transform.position;
            vec3[0] = endr;

            transform.position = vec3;

        }

        if (transform.position[0] < endl)
        {

            vec3 = transform.position;
            vec3[0] = endl;

            transform.position = vec3;

        }

    }
}
