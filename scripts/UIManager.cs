using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {
    [SerializeField]
    private GameObject gameover;
    // Use this for initialization
    void Start () {
        hidegameover();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void showgameover()
    {
        gameover.SetActive(true);
    }

    public void hidegameover()
    {

        gameover.SetActive(false);
      

    }
}


