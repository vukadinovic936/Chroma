using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SivaVrata : MonoBehaviour {
    public bool lights = false;
    public bool greenlights = false;
    public bool redlights = false;
    public bool blueLights = false;
    bool triger = true;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if ((lights == true) || (greenlights == true) || (redlights == true) || (blueLights == true))
        {
            triger = false;
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            gameObject.GetComponent<Collider2D>().isTrigger = true;
            triger = true;

        }
        else if ((lights == false) && (greenlights == false) && (redlights == false) && (blueLights == false))
        {

            gameObject.GetComponent<SpriteRenderer>().enabled = true;
            gameObject.GetComponent<Collider2D>().isTrigger = false;

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.gameObject.tag == "lights")
        {
            lights = true;
        }
        if (collision.gameObject.tag == "greenlights")
        {
            greenlights = true;
        }
        if (collision.gameObject.tag == "redlights")
        {
            redlights = true;
        }
        if (collision.gameObject.tag == "bluelights")
        {
            blueLights = true;
        }

        Debug.Log(collision.gameObject.name);




    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (triger)
        {
            if (collision.gameObject.tag == "lights")
            {
                lights = false;
            }
            if (collision.gameObject.tag == "greenlights")
            {
                greenlights = false;
            }
            if (collision.gameObject.tag == "redlights")
            {
                redlights = false;
            }
            if (collision.gameObject.tag == "bluelights")
            {
                blueLights = false;
            }
        }

    }
}
