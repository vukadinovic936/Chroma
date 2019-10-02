using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerStay2D(Collider2D collision)
    {

            Debug.Log("colision detectyed"+ collision.gameObject.name);
            collision.gameObject.GetComponent<Collider2D>().enabled = true;
            collision.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.255f, 0.0f, 0.255f, 1f);

            
        
        }


        }
    
//    private void OnTriggerExit2D(Collider2D collision)
//{
//    if (collision.gameObject.tag == "lights")
//    {

//        //obstacle.GetComponent<Collider2D>().enabled = false;
//        //obstacle.GetComponent<SpriteRenderer>().color = new Color(0.255f, 0.0f, 0.255f, 0.1f);

//    }