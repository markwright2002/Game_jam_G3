using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector2 vec;
    public Vector3 vec3;
    public float speed;
    public float endl, endr;
    public int hp;

    // Start is called before the first frame update
    void Start()
    {
        globalVars.HP = 3;
    }

    // Update is called once per frame
    void Update()
    {
        vec.x = Input.GetAxis("Horizontal");




        transform.position += (Vector3)vec * speed * Time.deltaTime;
        if(globalVars.HP <= 0)
        {

            SceneManager.LoadScene("death");

        }

        if (transform.position[0] > endr)
        {

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
