using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bolt : MonoBehaviour
{

    public Vector2 vec;
    public float speed, x;
    public GameObject bucket;
    public Collider2D bucCol, bltCol;
    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        bucket = GameObject.Find("bucket");
        if (bucket)
        {
            bucCol = bucket.GetComponent<Collider2D>();
        }
        speed = 10;
    }

    // Update is called once per frame
    void Update()
    {

        vec.x = 0;
        vec.y = -1;

        transform.position += (Vector3)vec * speed * Time.deltaTime;

        x += Time.deltaTime;

        if (bucCol)
        {
            if (bltCol.IsTouching(bucCol))
            {

                
                globalVars.engP++;
                Destroy(gameObject);


            }
        }

        if (x > 10)
        {
            Destroy(gameObject);
        }

    }
}
