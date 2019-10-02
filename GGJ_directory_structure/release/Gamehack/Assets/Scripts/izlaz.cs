using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class izlaz : MonoBehaviour {
    Camera ort;
	// Use this for initialization
	void Start () {
        ort = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("TRIGGER ENTER");
        float height = 2f * ort.orthographicSize;
        float width = height * ort.aspect;
        GameObject.Find("MainCamera").transform.position = GameObject.Find("MainCamera").transform.position + new Vector3(width, 0, 0);
        Destroy(gameObject);
    }
   
}
