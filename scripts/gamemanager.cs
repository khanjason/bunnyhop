using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemanager : MonoBehaviour {
    public bool gamestart = false;
[SerializeField]
    private UIManager uimanager;
    [SerializeField]
    private GameObject bunny;
   
    // Use this for initialization
    void Start () {
        uimanager = GameObject.Find("Canvas").GetComponent<UIManager>();
        uimanager.hidegameover();

        // bunny.GetComponent<Renderer>().enabled = true;
    }
	
	// Update is called once per frame
	void Update () {
        if (gamestart == true)
        {
          
            Debug.Log("Ben is a hoe");

           
        }
       // if (bunny.bunnydead = true)
        {

        }
    }
}
