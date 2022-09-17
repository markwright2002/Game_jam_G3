using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class obstacle : MonoBehaviour
{

    public Vector2 vec;
    public float speed, x;
    public GameObject player, exhast;
    public Collider2D plrCol, obsCol;
    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        player = GameObject.Find("player");
        exhast = GameObject.Find("exhast");
        if (player)
        {
            plrCol = player.GetComponent<Collider2D>();
        }


    }

    // Update is called once per frame
    void Update()
    {

        vec.x = 0;
        vec.y = -1;

        transform.position += (Vector3)vec * speed * Time.deltaTime;

        x += Time.deltaTime;
        if (plrCol)
        {
            if (obsCol.IsTouching(plrCol))
            {

                SceneManager.LoadScene("death");
                Destroy(player);
                Destroy(exhast);
                Destroy(gameObject);

            }
        }

        if (x > 10)
        {
            Destroy(gameObject);
        }
        
    }
}
