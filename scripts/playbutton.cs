using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playbutton : MonoBehaviour
{
    private UIManager uimanager;
    public gamemanager gamemanager;
    [SerializeField]
    private GameObject bunny;
    // Use this for initialization
    void Start()
    {
        uimanager = GameObject.Find("Canvas").GetComponent<UIManager>();
        transform.SetPositionAndRotation(new Vector3(0,0, -5), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {


    }
    private void OnMouseDown()
    {
        if (GameObject.Find("playbutton"));
        {
           
            Debug.Log("clicked");
            Instantiate(bunny, new Vector3(-750, -1.6f, 0), Quaternion.identity);
            bunny.transform.SetPositionAndRotation(new Vector3(-7.15f, -1.6f, -5), Quaternion.identity);
            bunny.SetActive(true);
             bunny.transform.SetPositionAndRotation(new Vector3(-7.15f, -1.6f, -5), Quaternion.identity);

            gamemanager.gamestart = true;
            Debug.Log("FUCK");
            this.gameObject.SetActive(false);
        }
        

    }
}