using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit_Zones : MonoBehaviour
{
    public float x_bound;
    private float Rando_Num;
    // Start is called before the first frame update
    void Start()
    {
        x_bound = GameObject.Find("Hit bounds").transform.position.x;
        x_bound = (x_bound + GameObject.Find("Hit bounds").transform.right.x *GameObject.Find("Hit bounds").transform.localScale.x/2) - (transform.position.x- x_bound + GameObject.Find("Hit bounds").transform.right.x * GameObject.Find("Hit bounds").transform.localScale.x / 2);
        Rando_Num = Random.Range(transform.position.x,x_bound); 
        this.gameObject.transform.position = new Vector3(Rando_Num, GameObject.Find("Hit bounds").transform.position.y, 0);
    }
}
