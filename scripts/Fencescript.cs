using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fencescript : MonoBehaviour {
    private float speed = 5.0f;
    private spawnamanger spawnman;
    
  
    
    // Use this for initialization
    void Start() {
      //  spawnman = GameObject.Find("spawnmanager").GetComponent<spawnamanger>();
        
        {
            // spawnman.startspawnroutines();
            
        }
    }

    // Update is called once per frame
    void Update() {
        movement();
        checkgo();
    }
   private void movement() {

        transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
    
    private void checkgo()
    {
        if (transform.position.x < -9.9f)
        {
            Destroy(this.gameObject);
            scoremanager.score += 1;
        }

    }
}
