using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cekipoint : MonoBehaviour {
    public int numberofCekipoint;
    public GameObject Bk1;
    public GameObject Bk2;
    public GameObject Bk3;
    public GameObject Bk4;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if(GameObject.Find("Player").GetComponent<Movement>().getOrientation())
            PlayerPrefs.SetFloat("XAXIS", -6.5f); //TODO //gameObject.transform.position.x
            PlayerPrefs.SetFloat("Bk1", 0);
            PlayerPrefs.SetFloat("Bk2", 0);
            PlayerPrefs.SetFloat("Bk3", 0);
            PlayerPrefs.SetFloat("Bk4", 0);
        }
    }
}
