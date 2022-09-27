using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit_Zones : MonoBehaviour
{
    public float x_bound;
    private float Rando_Num;
    private float x_start;
    // Start is called before the first frame update

    void OnEnable()
    {
        //score = 0;
        EventManager.OnHit += newPos;
        EventManager.OnMiss += newPos;
    }

    void OnDisable()
    {
        EventManager.OnHit -= newPos;
        EventManager.OnMiss -= newPos;
    }

    void Start()
    {
        x_start = transform.position.x;
        newPos();
    }

    void newPos()
    {
        
        x_bound = GameObject.Find("Hit bounds").transform.position.x;
        x_bound = (x_bound + GameObject.Find("Hit bounds").transform.right.x * GameObject.Find("Hit bounds").transform.localScale.x / 2) - (x_start - x_bound + GameObject.Find("Hit bounds").transform.right.x * GameObject.Find("Hit bounds").transform.localScale.x / 2);
        Rando_Num = Random.Range(x_start, x_bound);
        this.gameObject.transform.position = new Vector3(Rando_Num, GameObject.Find("Hit bounds").transform.position.y, 0);
    }
}
