using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onTvCollide : MonoBehaviour
{
    int svic;
    private GameObject[] svetla;
    private GameObject[] svetla0;
    private GameObject[] svetla1;
    private GameObject[] svetla2;
    bool exitt;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (svic > 0 && Input.GetKeyDown(KeyCode.Space))
        {
            if (svic == 1)
            {

                svetla = GameObject.FindGameObjectsWithTag("lights");
                Debug.Log("KURCINAA");

                    foreach (GameObject lights in svetla)
                    {
                    if (exitt == false) {
                        lights.GetComponent<SpriteRenderer>().enabled = true;
                        lights.GetComponent<CircleCollider2D>().enabled = true;
                    }
                    else
                    {
                        lights.GetComponent<SpriteRenderer>().enabled = false;
                        lights.GetComponent<CircleCollider2D>().enabled = false;
                    }
                }

            }

               


                       // lights.GetComponent<SpriteRenderer>().enabled = false;
                       // lights.GetComponent<CircleCollider2D>().enabled = false;
                    
                
            }
            if (svic == 2)
            {
                svetla = GameObject.FindGameObjectsWithTag("redlights");
            
                    foreach (GameObject lights in svetla)
                    {
                if (exitt == false) { 
                        lights.GetComponent<SpriteRenderer>().enabled = true;
                        lights.GetComponent<CircleCollider2D>().enabled = true;
                }
                else
                {
                    lights.GetComponent<SpriteRenderer>().enabled = false;
                    lights.GetComponent<CircleCollider2D>().enabled = false;
                }
            }
                
              
            }
            if (svic == 3)
            {
                svetla = GameObject.FindGameObjectsWithTag("greenlights");
            
                    foreach (GameObject lights in svetla)
                    {
                if (exitt == false)
                {
                    lights.GetComponent<SpriteRenderer>().enabled = true;
                    lights.GetComponent<CircleCollider2D>().enabled = true;
                }
                else
                {
                    lights.GetComponent<SpriteRenderer>().enabled = false;
                    lights.GetComponent<CircleCollider2D>().enabled = false;
                }
                       
                    }
                
                
            }
            if (svic == 4)
            {
            svetla = GameObject.FindGameObjectsWithTag("bluelights");

            foreach (GameObject lights in svetla)
            {
                if (exitt == false)
                {
                    lights.GetComponent<SpriteRenderer>().enabled = true;
                    lights.GetComponent<CircleCollider2D>().enabled = true;
                }
                else
                {
                    lights.GetComponent<SpriteRenderer>().enabled = false;
                    lights.GetComponent<CircleCollider2D>().enabled = false;
                }
            }
                
                
                
            }
        if (svic == 5)
        { if (exitt == false) { 
                svetla = GameObject.FindGameObjectsWithTag("bluelights");
                svetla0 = GameObject.FindGameObjectsWithTag("greenlights");
                svetla1 = GameObject.FindGameObjectsWithTag("redlights");
                svetla2 = GameObject.FindGameObjectsWithTag("lights");
                foreach (GameObject lights in svetla)
                {
                    lights.GetComponent<SpriteRenderer>().enabled = false;
                    lights.GetComponent<CircleCollider2D>().enabled = false;
                }
                foreach (GameObject lights in svetla0)
                {
                    lights.GetComponent<SpriteRenderer>().enabled = false;
                    lights.GetComponent<CircleCollider2D>().enabled = false;
                }
                foreach (GameObject lights in svetla1)
                {
                    lights.GetComponent<SpriteRenderer>().enabled = false;
                    lights.GetComponent<CircleCollider2D>().enabled = false;
                }
                foreach (GameObject lights in svetla2)
                {
                    lights.GetComponent<SpriteRenderer>().enabled = false;
                    lights.GetComponent<CircleCollider2D>().enabled = false;
                }
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Switch")
        {
            svic = collision.GetComponent<ctype>().tip;
            exitt = false;

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Switch")
        {
            svic = collision.GetComponent<ctype>().tip;
            exitt = true;

        }
    }
}

   


