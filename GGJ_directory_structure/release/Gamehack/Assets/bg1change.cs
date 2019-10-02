using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bg1change : MonoBehaviour {

    public Sprite spr1;
    public Sprite spr2;
    public Sprite spr3;
    public Sprite spr11;
    public Sprite spr22;
    public Sprite spr33;
    public GameObject bk1;
    public GameObject bk2;
    public GameObject bk3;
    public GameObject bk4;
    // Use this for initialization
    private void Awake()
    {
        Debug.Log("BK1" + PlayerPrefs.GetFloat("Bk1", 0f));
       bk1.transform.position = bk1.transform.position + new Vector3(PlayerPrefs.GetFloat("Bk1", 0f), 0, 0);
      bk2.transform.position = bk2.transform.position + new Vector3(PlayerPrefs.GetFloat("Bk2", 0f), 0, 0);
        bk3.transform.position = bk3.transform.position + new Vector3(PlayerPrefs.GetFloat("Bk3", 0f), 0, 0);
       bk4.transform.position=bk4.transform.position + new Vector3(PlayerPrefs.GetFloat("Bk4", 0f), 0, 0);

    }
    void Start () {
        Invoke("ChangePic11", 10f);
        Invoke("ChangePic21", 10f);
        Invoke("ChangePic12", 20f);
        Invoke("ChangePic21", 20f);
        Invoke("ChangePic13", 30f);
        Invoke("ChangePic23", 30f);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void ChangePic11()
    {
        foreach (GameObject obj in GameObject.FindGameObjectsWithTag("background1"))
        {
            obj.GetComponent<SpriteRenderer>().sprite = spr1;
        }
    }
    void ChangePic12()
    {
        foreach (GameObject obj in GameObject.FindGameObjectsWithTag("background1"))
        {
            obj.GetComponent<SpriteRenderer>().sprite = spr2;
        }
    }
    void ChangePic13()
    {
        foreach (GameObject obj in GameObject.FindGameObjectsWithTag("background1"))
        {
            obj.GetComponent<SpriteRenderer>().sprite = spr3;
        }
    }
    void ChangePic21()
    {
        foreach (GameObject obj in GameObject.FindGameObjectsWithTag("background2"))
        {
            obj.GetComponent<SpriteRenderer>().sprite = spr11;
        }
    }
    void ChangePic22()
    {
        foreach (GameObject obj in GameObject.FindGameObjectsWithTag("background2"))
        {
            obj.GetComponent<SpriteRenderer>().sprite = spr22;
        }
    }
    void ChangePic23()
    {
        foreach (GameObject obj in GameObject.FindGameObjectsWithTag("background2"))
        {
            obj.GetComponent<SpriteRenderer>().sprite = spr33;
        }
    }
}
