using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CyanPlatform : MonoBehaviour {

	int bluli = 0;
	int greenli = 0;




	void Start()
	{
		GameObject.Find ("ObstaclesOpacity").GetComponent<ObstaclesOpacity> ().setOsvetljeno3 (false);
		gameObject.GetComponent<Collider2D>().enabled = false;
		Color c = new Color(0.0f, 1.0f, 1.0f, 0.1f);
		c.a = 0.1f;
		gameObject.GetComponent<SpriteRenderer>().color = c;
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "bluelights")
		{
			bluli++;
		}
		if (collision.gameObject.tag == "greenlights")
		{
			greenli++;
		}
		if (bluli > 0 && greenli > 0) {
			GameObject.Find ("ObstaclesOpacity").GetComponent<ObstaclesOpacity> ().setOsvetljeno3 (true);
			gameObject.GetComponent<Collider2D>().enabled = true;
			gameObject.GetComponent<SpriteRenderer>().color = new Color(0.0f, 1.0f, 1.0f, 1f);
		}
	}
	private void OnTriggerExit2D(Collider2D collision)
	{

		if (collision.gameObject.tag == "greenlights")
		{
			greenli--;
		}
		if (collision.gameObject.tag == "bluelights")
		{
			bluli--;
		}
		if (bluli <= 0 || greenli <= 0) {
			GameObject.Find ("ObstaclesOpacity").GetComponent<ObstaclesOpacity> ().setOsvetljeno3 (false);
			gameObject.GetComponent<Collider2D>().enabled = false;
			Color c = new Color(0.0f, 1.0f, 1.0f, 0.1f);
			c.a = 0.1f;
			gameObject.GetComponent<SpriteRenderer>().color = c;
		}
	}

}
