using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPlatformScript : MonoBehaviour
{
    bool magenta=false;
    // Use this for initialization
    void Start()
    {
		GameObject.Find("ObstaclesOpacity").GetComponent<ObstaclesOpacity>().setOsvetljeno(false);
		gameObject.GetComponent<Collider2D>().enabled = false;
		Color c = new Color(1.0f, 1.0f, 1.0f, 1f);
		c.a = 0.1f;
		gameObject.GetComponent<SpriteRenderer>().color = c;
    }

    // Update is called once per frame

	void OnTriggerEnter2D (Collider2D collision){
		if (collision.gameObject.tag == "lights")
		{
			magenta = true;

		}
		if (magenta) {
			GameObject.Find ("ObstaclesOpacity").GetComponent<ObstaclesOpacity> ().setOsvetljeno (true);
			gameObject.GetComponent<Collider2D> ().enabled = true;
			gameObject.GetComponent<SpriteRenderer> ().color = new Color (1.0f, 1.0f, 1.0f, 1f);
		}
	}

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "lights")
        {
            magenta = false;

        }
		if (!magenta) {
			GameObject.Find("ObstaclesOpacity").GetComponent<ObstaclesOpacity>().setOsvetljeno(false);
			gameObject.GetComponent<Collider2D>().enabled = false;
			Color c = new Color(1.0f, 1.0f, 1.0f, 1f);
			c.a = 0.1f;
			gameObject.GetComponent<SpriteRenderer>().color = c;
		}
            
        

    }
}
