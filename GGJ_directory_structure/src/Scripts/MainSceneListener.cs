using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainSceneListener : MonoBehaviour {
    public Button mButton1;
    public Button mButton2;
    public Button mButton3;
    void Start()
    {
        Button btn = mButton1.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick1);
        Button btn2 = mButton2.GetComponent<Button>();
        btn2.onClick.AddListener(TaskOnClick2);
        Button btn3 = mButton3.GetComponent<Button>();
        btn3.onClick.AddListener(TaskOnClick3);

    }

    // Update is called once per frame
    void Update () {
		
	}
    void TaskOnClick1()
    {
        PlayerPrefs.SetInt("Continue", 0);
        Application.LoadLevel("MainScene");
    }
    void TaskOnClick2()
    {
        PlayerPrefs.SetInt("Continue", 1);
        Application.LoadLevel("MainScene");
    }
    void TaskOnClick3()
    {

    }
}
