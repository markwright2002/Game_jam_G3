using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class part : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector2 vec;
    public float speed, x;
    public GameObject hammer;
    public Collider2D hmrCol, prtCol;
    void Start()
    {
        x = 0;
        hammer = GameObject.Find("Hammer");
        if (hammer)
        {
            hmrCol = hammer.GetComponent<Collider2D>();
        }
        speed = 35;
    }

    // Update is called once per frame
    void Update()
    {
        vec.x = 1;
        vec.y = 0;

        transform.position += (Vector3)vec * speed * Time.deltaTime;

        x += Time.deltaTime;

        if (hmrCol)
        {
            if (prtCol.IsTouching(hmrCol))
            {


                globalVars.bodyP++;
                Destroy(gameObject);


            }
        }

        if (x > 2)
        {
            Destroy(gameObject);
        }
    }
}
