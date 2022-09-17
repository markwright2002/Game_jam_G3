using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject obs;
    public float x, y, z;
    // Start is called before the first frame update
    void Start()
    {
        x = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
        
        x += Time.deltaTime;
        if (x > 2.0)
        {
            GameObject clone1;

            clone1 = Instantiate(obs, new Vector3(Random.Range(y, z), transform.position[1], transform.position[2]), transform.rotation);

            //InstantiatePrefab();

            x = 0;
        }
    }
}
