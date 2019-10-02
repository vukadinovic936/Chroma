using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenPlatform : MonoBehaviour {
    bool greenl = false;
    // Use this for initialization
    void Start () {
		GameObject.Find("ObstaclesOpacity").GetComponent<ObstaclesOpacity>().setOsvetljeno2(false);
		gameObject.GetComponent<Collider2D>().enabled = false;
		Color c = new Color(0.0f, 1.0f, 0.0f, 0.1f);
		c.a = 0.1f;
		gameObject.GetComponent<SpriteRenderer>().color = c;
		greenl = false;
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		Debug.Log(collision.gameObject.name);
		if (collision.gameObject.tag == "greenlights")
		{
            greenl = true;
			GameObject.Find("ObstaclesOpacity").GetComponent<ObstaclesOpacity>().setOsvetljeno2(true);
			gameObject.GetComponent<Collider2D>().enabled = true;
			gameObject.GetComponent<SpriteRenderer>().color = new Color(0.0f, 1.0f, 0.0f, 1f);
          
        }
	}
	private void OnTriggerExit2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "greenlights")
		{
			GameObject.Find("ObstaclesOpacity").GetComponent<ObstaclesOpacity>().setOsvetljeno2(false);
			gameObject.GetComponent<Collider2D>().enabled = false;
			Color c = new Color(0.0f, 1.0f, 0.0f, 0.1f);
			c.a = 0.1f;
			gameObject.GetComponent<SpriteRenderer>().color = c;
            greenl = false;
        }

	}
}
