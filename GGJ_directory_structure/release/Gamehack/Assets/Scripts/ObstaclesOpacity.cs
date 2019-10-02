using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesOpacity : MonoBehaviour {
    private GameObject[] obstacles;
    private bool osvetljeno;
	private bool osvetljeno1;
	private bool osvetljeno2;
	private bool osvetljeno3;
	private bool osvetljeno4;
	private bool osvetljeno5;
	private bool osvetljeno6;
    private Color[] curCol;
	public int typeofplatform = 0;
    // Use this for initialization
    void Start () {
        obstacles = GameObject.FindGameObjectsWithTag("Obstacles");
        curCol = new Color[7];
    }

	/*
	// Update is called once per frame
	void Update () {
        
        foreach (GameObject obstacle in obstacles)
        {
            Debug.Log(obstacles.Length);
			typeofplatform = obstacle.GetComponent<ctype> ().tip;
			switch (typeofplatform) {
			case 0:
                    //tutorial
                    if (osvetljeno)
                    {

                        curCol[0] = new Color(1.0f, 1.0f, 1.0f, 1f);
                    }
                    else
                    {
                        curCol[0] = new Color(1.0f, 1.0f, 1.0f, 0.1f);
                    }
                    break;
			case 1:
				//yellow
				if (osvetljeno1) {

                        curCol[1] = new Color (1.0f, 1.0f, 0.0f, 1f);
				} else {
                        curCol[1] = new Color (1.0f, 1.0f, 0.0f, 0.1f);
				}
				break;
			case 2:
				//green
				if (osvetljeno2) {
                        curCol[2] = new Color (0.0f, 1.0f, 0.0f, 1f);
				} else {
                        curCol[2] = new Color (0.0f, 1.0f, 0.0f, 0.1f);
				}
				break;
			case 3:
				//cyan
				if (osvetljeno3) {
                        curCol[3] = new Color (0.0f, 1.0f, 1.0f, 1f);
				} else {
                        curCol[3] = new Color (0.0f, 1.0f, 1.0f, 0.1f);
				}
				break;
			case 4:
				//blue
				if (osvetljeno4) {
                        curCol[4] = new Color (0.0f, 0.0f, 1.0f, 1f);
				} else {
                        curCol[4] = new Color (0.0f, 0.0f, 1.0f, 0.1f);
				}
				break;
			case 5:
				//red
				if (osvetljeno5) {
                        curCol[5] = new Color (1.0f, 0.0f, 0.0f, 1f);
				} else {
                        curCol[5] = new Color (1.0f, 0.0f, 0.0f, 0.1f);
				}
				break;
			case 6:
				//purple
				if (osvetljeno6) {
                        curCol[6] = new Color (1.0f, 0.0f, 1.0f, 1f);
				} else {
                        curCol[6] = new Color (1.0f, 0.0f, 1.0f, 0.1f);
				}
				break;
			}
        }
    }
	*/


    public Color getCurrColor(int num)
    {
        return curCol[num];
    }
    public void setCurrColor(Color c)
    {

    }

    public void setOsvetljeno(bool set)
    {
        osvetljeno = set;
    }
	public void setOsvetljeno1(bool set)
	{
		osvetljeno1 = set;
	}
	public void setOsvetljeno2(bool set)
	{
		osvetljeno2 = set;
	}
	public void setOsvetljeno3(bool set)
	{
		osvetljeno3 = set;
	}
	public void setOsvetljeno4(bool set)
	{
		osvetljeno4 = set;
	}
	public void setOsvetljeno5(bool set)
	{
		osvetljeno5 = set;
	}
	public void setOsvetljeno6(bool set)
	{
		osvetljeno6 = set;
	}
    public bool getOsvetljeno()
    {
        return osvetljeno;
    }
	public bool getOsvetljeno1()
	{
		return osvetljeno1;
	}
	public bool getOsvetljeno2()
	{
		return osvetljeno2;
	}
	public bool getOsvetljeno3()
	{
		return osvetljeno3;
	}
	public bool getOsvetljeno4()
	{
		return osvetljeno4;
	}
	public bool getOsvetljeno5()
	{
		return osvetljeno5;
	}
	public bool getOsvetljeno6()
	{
		return osvetljeno6;
	}
}
