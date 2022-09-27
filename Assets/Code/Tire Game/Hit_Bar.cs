using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit_Bar : MonoBehaviour
{
    public int speed;
    public float xHigh_Bound, xLow_Bound,x_bound;
    public bool high, low,hit;
    // Start is called before the first frame update
    void Start()
    {
        xLow_Bound = transform.position.x;
        low = true;
        high = false;
        hit = false;
        x_bound = GameObject.Find("Hit bounds").transform.position.x;
        xHigh_Bound = (xHigh_Bound + GameObject.Find("Hit bounds").transform.right.x * (x_bound + GameObject.Find("Hit bounds").transform.right.x * GameObject.Find("Hit bounds").transform.localScale.x / 2));
    }

    // Update is called once per frame
    void Update()
    {
               
        if (high == true)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            Above();
        }
        

        else if (low == true)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            lowwer();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            if (transform.position.x >= (GameObject.Find("Hit Zone").transform.position.x-2) && transform.position.x <= (GameObject.Find("Hit Zone").transform.position.x+1))
            {
                //low = false;
                //high = false;
                //hit = true;
                //transform.Translate(Vector2.zero * 1 * Time.deltaTime);
                Debug.Log("You hit");
                EventManager.InvokeOnHit();
            }
            else
            {
                //low = false;
                //high = false;
                //transform.Translate(Vector2.zero * 1 * Time.deltaTime);
                Debug.Log("you missed");
                EventManager.InvokeOnMiss();

            }
            

        }
    }
    void Above()
    {
        if (transform.position.x >= xHigh_Bound)
        {
            low = true;
            high = false;
        }
    }
    void lowwer()
    {
        if (transform.position.x <= xLow_Bound - 1)
        {
            high = true;
            low = false;
        }
    }
}
