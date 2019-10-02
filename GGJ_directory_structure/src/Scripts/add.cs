using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class add : MonoBehaviour {
	// Use this for initialization
	void Start () {
        Button btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void TaskOnClick()
    {
        PlayerPrefs.SetInt("Continue", 1);
        Application.LoadLevel("MainScene");
    }
}
