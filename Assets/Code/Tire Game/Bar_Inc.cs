using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bar_Inc : MonoBehaviour
{
    public float i,n,q;
    private Vector3 StartPos;
    [SerializeField] private float End_Time;
    public bool Did_End = false;
    public float xHigh_Bound, x_bound;
    // Start is called before the first frame update
    void Start()
    {
        StartPos = this.gameObject.transform.position;
        x_bound = GameObject.Find("Hit bounds").transform.position.x;
        xHigh_Bound = (xHigh_Bound + GameObject.Find("Hit bounds").transform.right.x * (x_bound + GameObject.Find("Hit bounds").transform.right.x * GameObject.Find("Hit bounds").transform.localScale.x / 2));
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(ExecuteAfterTime(End_Time));
        if (Did_End == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (this.gameObject.transform.position.x >= xHigh_Bound)
                {
                    this.gameObject.transform.Translate(new Vector2(0, 0));
                }
                else
                {
                    this.gameObject.transform.Translate(new Vector2(i, 0));
                    this.gameObject.transform.Translate(new Vector2(0, 0));
                    i += n;
                }
                
            }
            if (Input.GetKeyDown(KeyCode.Space) == false)
            {
                if (this.gameObject.transform.position.x <= StartPos.x)
                {
                    this.gameObject.transform.Translate(new Vector2(0, 0));
                }
                else
                {

                    this.gameObject.transform.Translate(new Vector2(-q, 0));
                }


            }
        }
        
    }
    IEnumerator ExecuteAfterTime(float time)
    {
        
        yield return new WaitForSeconds(time);
        Did_End = true;
        this.gameObject.transform.Translate(Vector2.zero);
        
    }
}
