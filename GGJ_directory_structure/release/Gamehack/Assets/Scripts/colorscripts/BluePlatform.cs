using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePlatform : MonoBehaviour {
	int blue;
	// Use this for initialization
	void Start () {
		blue = 0;
		GameObject.Find("ObstaclesOpacity").GetComponent<ObstaclesOpacity>().setOsvetljeno4(false);
		gameObject.GetComponent<Collider2D>().enabled = false;
		Color c = new Color(0.0f, 0.0f, 1.0f, 0.1f);
		c.a = 0.1f;
		gameObject.GetComponent<SpriteRenderer>().color = c;
	}
	

	private void OnTriggerEnter2D(Collider2D collision)
	{
		Debug.Log(collision.gameObject.name);
		if (collision.gameObject.tag == "bluelights")
		{
			blue++;
			if (blue > 0) {
				GameObject.Find ("ObstaclesOpacity").GetComponent<ObstaclesOpacity> ().setOsvetljeno4 (true);
				gameObject.GetComponent<Collider2D> ().enabled = true;
				gameObject.GetComponent<SpriteRenderer> ().color = new Color (0.0f, 0.0f, 1.0f, 1f);
			}
        }
	}
	private void OnTriggerExit2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "bluelights")
		{
            blue--;
			if (blue <= 0) {
				GameObject.Find ("ObstaclesOpacity").GetComponent<ObstaclesOpacity> ().setOsvetljeno4 (false);
				gameObject.GetComponent<Collider2D> ().enabled = false;
				Color c = new Color (0.0f, 0.0f, 1.0f, 0.1f);
				c.a = 0.1f;
				gameObject.GetComponent<SpriteRenderer> ().color = c;
			}
        }

	}
}
