using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bar_Inc : MonoBehaviour
{
    public float i,n,q;
    private Vector3 StartPos;
    // Start is called before the first frame update
    void Start()
    {
        StartPos = this.gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            this.gameObject.transform.Translate(new Vector2(i, 0));
            this.gameObject.transform.Translate(new Vector2(0, 0));
            i+=n;
        }
        if (Input.GetKeyDown(KeyCode.Space) == false){
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
