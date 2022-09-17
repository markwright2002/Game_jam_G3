using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour
{

    public Vector2 vec;
    public float speed, x;
    // Start is called before the first frame update
    void Start()
    {
        x = 0;

    }

    // Update is called once per frame
    void Update()
    {

        vec.x = 0;
        vec.y = -1;

        transform.position += (Vector3)vec * speed * Time.deltaTime;

        x += Time.deltaTime;
        if (x > 10)
        {
            Destroy(gameObject);
        }
        
    }
}
