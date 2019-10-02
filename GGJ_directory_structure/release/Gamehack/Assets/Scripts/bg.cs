using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bg : MonoBehaviour
{
    bool taccc = false;
   
    void Start()
    {
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            taccc = true;
        }
    }
    void OnTriggerExit2D(Collider2D collider)
    {
        bool orient = GameObject.Find("Player").GetComponent<Movement>().getOrientation();
        if (collider.gameObject.tag == "Player" && orient==true)
        {
            
            float width = ((BoxCollider2D)gameObject.GetComponent<Collider2D>()).size.x;
            Vector3 pos = gameObject.transform.position;
            pos.x += width * 2.5f;
            Debug.Log("sasda");
            GameObject go = Instantiate(gameObject);
            go.tag = "TAG";
            gameObject.transform.position = pos;

        }
    }
    
  
}

