using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCounter : MonoBehaviour
{

    public GameObject l1, l2, l3, l4, l5;
    private int x;
    // Start is called before the first frame update
    void Start()
    {

        l1 = GameObject.Find("1");
        l2 = GameObject.Find("2");
        l3 = GameObject.Find("3");
        l4 = GameObject.Find("4");
        l5 = GameObject.Find("5");

    }

        // Update is called once per frame
        void Update()
    {
        x = Car.health;
        if (x < 5 && l5)
        {
            Destroy(l5);
        }
        if (x < 4 && l4)
        {
            Destroy(l4);
        }
        if (x < 3 && l3)
        {
            Destroy(l3);
        }
        if (x < 2 && l2)
        {
            Destroy(l2);
        }
        if (x < 1 && l1)
        {
            Destroy(l1);
        }


    }
}
