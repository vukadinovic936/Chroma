using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowPlatform : MonoBehaviour
{
	int redli = 0;
	int greenli = 0;

	// Use this for initialization
	void Start()
	{
		GameObject.Find ("ObstaclesOpacity").GetComponent<ObstaclesOpacity> ().setOsvetljeno1 (false);
		gameObject.GetComponent<Collider2D>().enabled = false;
		Color c = new Color(1.0f, 1.0f, 0.0f, 0.1f);
		c.a = 0.1f;
		gameObject.GetComponent<SpriteRenderer>().color = c;
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "redlights")
		{
			redli++;
		}
		if (collision.gameObject.tag == "greenlights")
		{
			greenli++;
		}
		if (redli > 0 && greenli > 0) {
			GameObject.Find ("ObstaclesOpacity").GetComponent<ObstaclesOpacity> ().setOsvetljeno1 (true);
			gameObject.GetComponent<Collider2D>().enabled = true;
			gameObject.GetComponent<SpriteRenderer>().color = new Color(1.0f, 1.0f, 0.0f, 1f);
		}
	}
	private void OnTriggerExit2D(Collider2D collision)
	{

		if (collision.gameObject.tag == "greenlights")
		{
			greenli--;
		}
		if (collision.gameObject.tag == "redlights")
		{
			redli--;
		}
		if (redli <= 0 || greenli <= 0) {
			GameObject.Find ("ObstaclesOpacity").GetComponent<ObstaclesOpacity> ().setOsvetljeno1 (false);
			gameObject.GetComponent<Collider2D>().enabled = false;
			Color c = new Color(1.0f, 1.0f, 0.0f, 0.1f);
			c.a = 0.1f;
			gameObject.GetComponent<SpriteRenderer>().color = c;
		}
	}
}
