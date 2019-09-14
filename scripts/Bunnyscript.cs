using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bunnyscript : MonoBehaviour
{

    [SerializeField]
    private UIManager uimanager;
    [SerializeField]
    private float speed = 10.01f;
    private float deac = 9.8f;
    [SerializeField]
    private Sprite[] bunnyposes;
    private bool flying = false;
    public gamemanager gamemanager;
    private float runningpause= 0.1f;
    [SerializeField]
    public static bool bunnydead = false;
    [SerializeField]
    private GameObject gameover;
    public Text text;

    // Use this for initialization
    public int x = 0;
    void Start()
    {
       
        {
            bunnydead = false;
            uimanager = GameObject.Find("Canvas").GetComponent<UIManager>();

            //Instantiate(gameover, new Vector3(-26.3f, 99.2f, -6.0f), Quaternion.identity);
            //text = gameover.GetComponent<Text>();
           // text.text = " ";
           // gameover.SetActive(false);
            GetComponent<Rigidbody2D>().gravityScale = 0.3f;
            
            //this.gameObject.SetActive(false);
           // transform.SetPositionAndRotation(new Vector3(-7.15f, -1.6f, -5), Quaternion.identity);
          
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        if (flying == false)
        {
            InvokeRepeating("running", runningpause, runningpause);
        }
        
        //OnCollisionEnter2D(Collision2D other);
        float verticalInput = Input.GetAxis("Vertical");
        if (transform.position.y < -1.6f)
        {
            transform.SetPositionAndRotation(new Vector3(-7.15f, -1.6f, -5), Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {//s=ut+ o.5 at^2
            
            while (transform.position.y < 3.15f)
            {
                flying = true;
                //GetComponent<Sprite bunnyposes[2];
                GetComponent<SpriteRenderer>().sprite = bunnyposes[2];
                // Rigidbody2D  = 1;
                GetComponent<Rigidbody2D>().gravityScale = 0;
                transform.Translate(new Vector3(0, 200, 0) * Time.deltaTime * Time.deltaTime * speed);

            }
           
        }
        if (bunnydead == true)
        {
            //gameover.SetActive(true);
            // text = gameover.GetComponent<Text>();
            uimanager.showgameover();

            //  text.text = "Game Over!";
            Debug.Log("Nibba he ded");

        }
    }
    //boxcollider
    // if collision between bunny and grass detected, gravity is set to zero
    //running action plays
    private void OnCollisionEnter2D(Collision2D other)
    {
        
        if (other.gameObject.tag == "grass")
        {
           
            GetComponent<Rigidbody2D>().gravityScale = 0;
            


        }
       
        // transform.Translate(Vector3.up * Time.deltaTime * speed * verticalInput);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Collided with:" + other.name);
        flying = false;
        if (other.tag == "fence")
        {
            scoremanager.score = 0;
            uimanager.showgameover();
            bunnydead = true;
            
            
            //gameover.SetActive(true);
            Debug.Log("slut");
            Destroy(this.gameObject);
        }
    }
            private void running()
    {
        if (flying == false)
        {


            GetComponent<SpriteRenderer>().sprite = bunnyposes[x];
            x++;
            if (x == 2)
            {
                x = 0;
            }
        }
    }
}

