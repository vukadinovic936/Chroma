using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    public float speed; // SPEED CAN GO FROM 0 to 0.5 if it is higher it will fly like fuck
    private Vector3 vctr;
	int svic;
    public float jumpSpeed = 8f;
    private float movement = 0f;
    private Rigidbody2D rigidBody;
    public Transform groundCheckPoint;
    public float groundCheckRadius;
    public LayerMask groundLayer;
    private bool isTouchingGround;
    private bool Death;
	float jumpdecay = 0;
	public float maxdecay = 3;
	bool sapatosa=false;
    bool lights = false;
    public GameObject[] tobedisabled;
    bool greenlights = false;
    bool redlights = false;
    bool blueLights = false;
    bool hasKey = false;
    private GameObject[] svetla;
	private GameObject[] svetla0;
	private GameObject[] svetla1;
	private GameObject[] svetla2;
    private bool osvetljeno;
    public Texture btnTexture;
    GameObject keyy;
    public float jumphigh; //0  - 1
    private Vector3 defaultpos;
    bool CollideCheck = true;
    bool right = false;
    public GameObject kljuc;
	public GameObject anim;
    GameObject c;
	GameObject dest;
    public GameObject duga;
    // Use this for initialization
    private void Awake()
    {
        if (PlayerPrefs.GetInt("Continue") == 1) {
    
            gameObject.transform.position=  gameObject.transform.position + new Vector3(PlayerPrefs.GetFloat("XAXIS")- gameObject.transform.position.x, 0, 0);
           
        }
    }
    void Start () {
        c = GameObject.Find("Canvas");
       c.SetActive(false);

    }

    // Update is called once per frame
    void Update () {
        Debug.Log(hasKey);
       GameObject trace= Instantiate(duga, gameObject.transform.position, gameObject.transform.rotation);
       Destroy(trace, 0.55f);
        isTouchingGround = Physics2D.OverlapCircle(groundCheckPoint.position, groundCheckRadius, groundLayer);
       
        if (Input.GetKeyDown(KeyCode.UpArrow) && isTouchingGround)
        {
            GameObject.Find("Player").GetComponent<Rigidbody2D>().AddForce(new Vector3(0, 15, 0), ForceMode2D.Impulse);
        }
    
        if (Death != true) {
        if(lights==true || greenlights==true || blueLights==true || redlights == true)
        {
            anim.GetComponent<Animator>().SetBool("boja", true);
        }
        else
        {
            anim.GetComponent<Animator>().SetBool("boja", false);

        }
		float x = Input.GetAxis("Horizontal");
		if (x != 0) {
			
			anim.GetComponent<Animator> ().SetBool ("trchanje", true);
		} else {
			anim.GetComponent<Animator> ().SetBool ("trchanje", false);
		}
			if (CollideCheck) {
				anim.GetComponent<Animator> ().SetBool ("jeluvazduh", false);
			} else {
				anim.GetComponent<Animator>().SetBool("jeluvazduh", true);
			}
        if (x > 0)
        {
            if (right != true)
            {
                transform.localScale = new Vector3(transform.localScale.x * -1, 10f, 2f);
                right = true;
            }
        }
        else if (x < 0)
            if (right == true)
            {
                transform.localScale = new Vector3(transform.localScale.x * -1, 10f, 2f);
                right = false;
            }
        
        vctr = new Vector3(x * speed, 0,0);
        transform.position = transform.position + vctr;
        }
		if (Death == true) {
			Instantiate (Resources.Load ("Rainbow"), transform.position, Quaternion.identity);
			defaultpos = gameObject.transform.position + new Vector3 (PlayerPrefs.GetFloat ("XAXIS") - gameObject.transform.position.x, 0, 0);
			anim.SetActive(false);
			ShowCanvas ();
            
		} else {
			anim.SetActive(true);
			dest = GameObject.Find ("Rainbow");
			Destroy (dest);
		}
        if (svic > 0 && Input.GetKeyDown(KeyCode.Space))
        {
			if (svic == 1) {
				osvetljeno = GameObject.FindGameObjectWithTag("Opacity").GetComponent<ObstaclesOpacity>().getOsvetljeno();
				Debug.Log(osvetljeno);
				svetla = GameObject.FindGameObjectsWithTag("lights");

				if (svetla[0].GetComponent<SpriteRenderer>().enabled == false)
				{
					foreach(GameObject lights in svetla)
					{
						foreach (Transform kid in lights.transform.parent) {
							if (kid.name == "Monolith") {
								kid.gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("beli");
							}
							if (kid.name == "PulseLight") {
								kid.gameObject.SetActive(true);
							}
						}

						lights.GetComponent<SpriteRenderer>().enabled = true;
						lights.GetComponent<CircleCollider2D>().enabled = true;
					} 
				}
				else
				{
					foreach (GameObject lights in svetla)
					{
						foreach (Transform kid in lights.transform.parent) {
							if (kid.name == "Monolith") {
								kid.gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("monomer");
							}
							if (kid.name == "PulseLight") {
								kid.gameObject.SetActive(false);
							}
						}

						lights.GetComponent<SpriteRenderer>().enabled = false;
						lights.GetComponent<CircleCollider2D>().enabled = false;
					}
				}
			}
			if (svic == 2) {
				osvetljeno = GameObject.FindGameObjectWithTag("Opacity").GetComponent<ObstaclesOpacity>().getOsvetljeno5();
				Debug.Log(osvetljeno);
				svetla = GameObject.FindGameObjectsWithTag("redlights");

				if (svetla[0].GetComponent<SpriteRenderer>().enabled == false)
				{
					foreach(GameObject lights in svetla)
					{
						foreach (Transform kid in lights.transform.parent) {
							if (kid.name == "Monolith") {
								kid.gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("crveni");
							}
							if (kid.name == "PulseLight") {
								kid.gameObject.SetActive(true);
							}
						}

						lights.GetComponent<SpriteRenderer>().enabled = true;
						lights.GetComponent<CircleCollider2D>().enabled = true;
					} 
				}
				else
				{
					
					foreach (GameObject lights in svetla)
					{
						foreach (Transform kid in lights.transform.parent) {
							if (kid.name == "Monolith") {
								kid.gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("monomer");
							}
							if (kid.name == "PulseLight") {
								kid.gameObject.SetActive(false);
							}
						}

						lights.GetComponent<SpriteRenderer>().enabled = false;
						lights.GetComponent<CircleCollider2D>().enabled = false;
					}
				}
			}
			if (svic == 3) {
				osvetljeno = GameObject.FindGameObjectWithTag("Opacity").GetComponent<ObstaclesOpacity>().getOsvetljeno2();
				Debug.Log(osvetljeno);
				svetla = GameObject.FindGameObjectsWithTag("greenlights");

				if (svetla[0].GetComponent<SpriteRenderer>().enabled == false)
				{
					foreach(GameObject lights in svetla)
					{
						foreach (Transform kid in lights.transform.parent) {
							if (kid.name == "Monolith") {
								kid.gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("zeleni");
							}
							if (kid.name == "PulseLight") {
								kid.gameObject.SetActive(true);
							}
						}

						lights.GetComponent<SpriteRenderer>().enabled = true;
						lights.GetComponent<CircleCollider2D>().enabled = true;
					} 
				}
				else
				{
					foreach (GameObject lights in svetla)
					{
						foreach (Transform kid in lights.transform.parent) {
							if (kid.name == "Monolith") {
								kid.gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("monomer");
							}
							if (kid.name == "PulseLight") {
								kid.gameObject.SetActive(false);
							}
						}

						lights.GetComponent<SpriteRenderer>().enabled = false;
						lights.GetComponent<CircleCollider2D>().enabled = false;
					}
				}
			}
			if (svic == 4) {
				osvetljeno = GameObject.FindGameObjectWithTag("Opacity").GetComponent<ObstaclesOpacity>().getOsvetljeno3();
				Debug.Log(osvetljeno);
				svetla = GameObject.FindGameObjectsWithTag("bluelights");

				if (svetla[0].GetComponent<SpriteRenderer>().enabled == false)
				{
					foreach(GameObject lights in svetla)
					{
						foreach (Transform kid in lights.transform.parent) {
							if (kid.name == "Monolith") {
								kid.gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("plavi");
							}
							if (kid.name == "PulseLight") {
								kid.gameObject.SetActive(true);
							}
						}

						lights.GetComponent<SpriteRenderer>().enabled = true;
						lights.GetComponent<CircleCollider2D>().enabled = true;
					} 
				}
				else
				{
					foreach (GameObject lights in svetla)
					{
						foreach (Transform kid in lights.transform.parent) {
							if (kid.name == "Monolith") {
								kid.gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("monomer");
							}
							if (kid.name == "PulseLight") {
								kid.gameObject.SetActive(false);
							}
						}

						lights.GetComponent<SpriteRenderer>().enabled = false;
						lights.GetComponent<CircleCollider2D>().enabled = false;
					}
				}
			}
			if (svic == 5) {
				svetla = GameObject.FindGameObjectsWithTag("bluelights");
				svetla0 = GameObject.FindGameObjectsWithTag("greenlights");
				svetla1 = GameObject.FindGameObjectsWithTag("redlights");
				svetla2 = GameObject.FindGameObjectsWithTag("lights");
				foreach (GameObject lights in svetla)
				{
					foreach (Transform kid in lights.transform.parent) {
						if (kid.name == "Monolith") {
							kid.gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("monomer");
						}
						if (kid.name == "PulseLight") {
							kid.gameObject.SetActive(false);
						}
					}
					lights.GetComponent<SpriteRenderer>().enabled = false;
					lights.GetComponent<CircleCollider2D>().enabled = false;
				}
				foreach (GameObject lights in svetla0)
				{
					foreach (Transform kid in lights.transform.parent) {
						if (kid.name == "Monolith") {
							kid.gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("monomer");
						}
						if (kid.name == "PulseLight") {
							kid.gameObject.SetActive(false);
						}
					}
					lights.GetComponent<SpriteRenderer>().enabled = false;
					lights.GetComponent<CircleCollider2D>().enabled = false;
				}
				foreach (GameObject lights in svetla1)
				{
					foreach (Transform kid in lights.transform.parent) {
						if (kid.name == "Monolith") {
							kid.gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("monomer");
						}
						if (kid.name == "PulseLight") {
							kid.gameObject.SetActive(false);
						}
					}
					lights.GetComponent<SpriteRenderer>().enabled = false;
					lights.GetComponent<CircleCollider2D>().enabled = false;
				}
				foreach (GameObject lights in svetla2)
				{
					foreach (Transform kid in lights.transform.parent) {
						if (kid.name == "Monolith") {
							kid.gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("monomer");
						}
						if (kid.name == "PulseLight") {
							kid.gameObject.SetActive(false);
						}
					}

					lights.GetComponent<SpriteRenderer>().enabled = false;
					lights.GetComponent<CircleCollider2D>().enabled = false;
				}
			}
            if (svic == 6)
            {
                //WHITE WITH KEY
                if (hasKey == true) { 
                osvetljeno = GameObject.FindGameObjectWithTag("Opacity").GetComponent<ObstaclesOpacity>().getOsvetljeno();
                Debug.Log(osvetljeno);
                svetla = GameObject.FindGameObjectsWithTag("lights");

                if (svetla[0].GetComponent<SpriteRenderer>().enabled == false)
                {
                    foreach (GameObject lights in svetla)
                    {
							foreach (Transform kid in lights.transform.parent) {
								if (kid.name == "Monolith") {
									kid.gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("beli");
								}
								if (kid.name == "PulseLight") {
									kid.gameObject.SetActive(true);
								}
							}
                        lights.GetComponent<SpriteRenderer>().enabled = true;
                        lights.GetComponent<CircleCollider2D>().enabled = true;
                    }
                }
                else
                {
                    foreach (GameObject lights in svetla)
                    {
							foreach (Transform kid in lights.transform.parent) {
								if (kid.name == "Monolith") {
									kid.gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("monomer");
								}
								if (kid.name == "PulseLight") {
									kid.gameObject.SetActive(false);
								}
							}
                        lights.GetComponent<SpriteRenderer>().enabled = false;
                        lights.GetComponent<CircleCollider2D>().enabled = false;
                    }
                }
                    hasKey = false;
                    Destroy(keyy);
                    
                }
               }
            if (svic == 7)
            {
                //RED WITH KEY
                if (hasKey == true) {
                    Debug.Log("NESTONESTONESOT");
                osvetljeno = GameObject.FindGameObjectWithTag("Opacity").GetComponent<ObstaclesOpacity>().getOsvetljeno5();
                Debug.Log(osvetljeno);
                svetla = GameObject.FindGameObjectsWithTag("redlights");

                if (svetla[0].GetComponent<SpriteRenderer>().enabled == false)
                {
                    foreach (GameObject lights in svetla)
                    {
                        lights.GetComponent<SpriteRenderer>().enabled = true;
                        lights.GetComponent<CircleCollider2D>().enabled = true;
                    }
                }
                else
                {
                    foreach (GameObject lights in svetla)
                    {


                        lights.GetComponent<SpriteRenderer>().enabled = false;
                        lights.GetComponent<CircleCollider2D>().enabled = false;
                    }
                }
                    hasKey = false;
                    Destroy(keyy);
                }
            }
            if (svic == 8)
            {   //GREEN WITH KEY
                if (hasKey == true) { 
                osvetljeno = GameObject.FindGameObjectWithTag("Opacity").GetComponent<ObstaclesOpacity>().getOsvetljeno2();
                Debug.Log(osvetljeno);
                svetla = GameObject.FindGameObjectsWithTag("greenlights");

                if (svetla[0].GetComponent<SpriteRenderer>().enabled == false)
                {
                    foreach (GameObject lights in svetla)
                    {
                        lights.GetComponent<SpriteRenderer>().enabled = true;
                        lights.GetComponent<CircleCollider2D>().enabled = true;
                    }
                }
                else
                {
                    foreach (GameObject lights in svetla)
                    {


                        lights.GetComponent<SpriteRenderer>().enabled = false;
                        lights.GetComponent<CircleCollider2D>().enabled = false;
                    }
                }
                    hasKey = false;
                    Destroy(keyy);
                }
            }
            if (svic == 9)
            {
                //BLUE WITH KEY
                if (hasKey == true)
                {
                    osvetljeno = GameObject.FindGameObjectWithTag("Opacity").GetComponent<ObstaclesOpacity>().getOsvetljeno3();
                    Debug.Log(osvetljeno);
                    svetla = GameObject.FindGameObjectsWithTag("bluelights");

                    if (svetla[0].GetComponent<SpriteRenderer>().enabled == false)
                    {
                        foreach (GameObject lights in svetla)
                        {
                            lights.GetComponent<SpriteRenderer>().enabled = true;
                            lights.GetComponent<CircleCollider2D>().enabled = true;
                        }
                    }
                    else
                    {
                        foreach (GameObject lights in svetla)
                        {


                            lights.GetComponent<SpriteRenderer>().enabled = false;
                            lights.GetComponent<CircleCollider2D>().enabled = false;
                        }
                    }
                    hasKey = false;
                    Destroy(GameObject.FindGameObjectWithTag("forDestroy"));
                   
                }
            }
        }
        

    }
 
    private void OnCollisionEnter2D(Collision2D collision)
    {   
        if (collision.gameObject.tag == "Provalija")
        {
            Death = true;
        }
        if (collision.gameObject.name == "kljuc")
        {
           
            hasKey = true;
            keyy= Instantiate(kljuc, gameObject.transform.position + new Vector3(0, 1.7f, 0), gameObject.transform.rotation);
            keyy.tag = "forDestroy";
            keyy.transform.parent = gameObject.transform;
            Destroy(collision.gameObject);
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Switch" )
        {
			svic = collision.GetComponent<ctype>().tip;
 
        }
        if(collision.gameObject.tag == "lights")
        {
            lights = true;
        }
        if (collision.gameObject.tag == "greenlights")
        {
            greenlights = true;
        }
        if (collision.gameObject.tag == "redlights")
        {
            redlights = true;
            Debug.Log("FUC");
        }
        if(collision.gameObject.tag == "bluelights")
        {
            blueLights = true;
        }
        
        Debug.Log(collision.gameObject.name);
        
       
        
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
		if (collision.gameObject.tag == "MainPlatform" || collision.gameObject.tag == "Obstacles" || collision.gameObject.tag == "box")
        {
            CollideCheck = true;
            Debug.Log("kolizn");
        }
        
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
		if (collision.gameObject.tag == "MainPlatform" || collision.gameObject.tag == "Obstacles" || collision.gameObject.tag == "box")
        {
            Debug.Log("EXIT");
            CollideCheck = false;
        }
        

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Switch")
        {
			svic = 0;

        }
        if (collision.gameObject.tag == "lights")
        {

            lights = false;
        }
        if (collision.gameObject.tag == "greenlights")
        {
            greenlights = false;
        }
        if (collision.gameObject.tag == "redlights")
        {
            redlights = false;
            Debug.Log("RADDIII");
        }
        if (collision.gameObject.tag == "bluelights")
        {
            blueLights = false;
        }


    }
    private void OnCollisionStay(Collision collision)
    {
        
        
    }
    public bool getOrientation()
    {
        return right;
    }
    void ShowCanvas()
    {
        c.SetActive(true);

    }
  

}
