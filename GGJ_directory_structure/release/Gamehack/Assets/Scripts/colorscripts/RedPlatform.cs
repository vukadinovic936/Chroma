using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPlatform : MonoBehaviour {
    int red = 0;
	// Use this for initialization
	void Start () {
		red = 0;
		GameObject.Find("ObstaclesOpacity").GetComponent<ObstaclesOpacity>().setOsvetljeno6(false);
		gameObject.GetComponent<Collider2D>().enabled = false;
		Color c = new Color(1.0f, 0.0f, 0.0f, 1f);
		c.a = 0.1f;
		gameObject.GetComponent<SpriteRenderer>().color = c;
    }
	
	// Update is called once per frame

		
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "redlights")
		{
            red++;
			if (red > 0) {
				GameObject.Find ("ObstaclesOpacity").GetComponent<ObstaclesOpacity> ().setOsvetljeno5 (true);
				gameObject.GetComponent<Collider2D> ().enabled = true;
				gameObject.GetComponent<SpriteRenderer> ().color = new Color (1.0f, 0.0f, 0.0f, 1f);
			}
        }
	}
	private void OnTriggerExit2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "redlights")
		{
            red--;
			if (red <= 0) {
				GameObject.Find ("ObstaclesOpacity").GetComponent<ObstaclesOpacity> ().setOsvetljeno6 (false);
				gameObject.GetComponent<Collider2D> ().enabled = false;
				Color c = new Color (1.0f, 0.0f, 0.0f, 1f);
				c.a = 0.1f;
				gameObject.GetComponent<SpriteRenderer> ().color = c;
			}
        }

	}
}
