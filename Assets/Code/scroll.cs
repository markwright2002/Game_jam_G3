using UnityEngine;
using System.Collections;

public class scroll : MonoBehaviour {

public float speed = 0.5f;

//use this for initialization
void Start () {
	
}
//Update is called once per fram
void Update () {
	Vector2 offset = new Vector2(0 , Time.time * speed);
	
	GetComponent<Renderer>().material.mainTextureOffset = offset;
}

}