using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnamanger : MonoBehaviour {
    [SerializeField]
    private GameObject fenceprefab;
    public float spawnTime = 3f;
    // Use this for initialization
    public gamemanager gamemanager;
   
    [SerializeField]
    private GameObject bunny;
    void Start () {
        // StartCoroutine(fencespawnroutine());
       
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }
	
	// Update is called once per frame
	void Update () {
       
    }
    public void startspawnroutines()
    {

       // StartCoroutine(fencespawnroutine());
        

    }
    public void Spawn()
    {
        if (gamemanager.gamestart == true) //&& (bunny.bunnydead==false))
        {
            {
                int randomfenceheight = Random.Range(1, 2);
                float fencethiccness = randomfenceheight * 0.6f;
                // times the y scale by 3/5
                // when y scale increased by 1, add 0.3 to position y
                // y=4 position y= -1.55
                // y=5  positon y=-1.3
                // y=6 y position y=-1
                // y=7 position y=-0.75
                if (randomfenceheight == 4)
                {
                    fenceprefab.transform.localScale = new Vector3(fencethiccness, randomfenceheight, 0);
                    Instantiate(fenceprefab, new Vector3(7.555f, -1.55f, -5), Quaternion.identity);
                    //yield return new WaitForSeconds(5.0f);
                }
                if (randomfenceheight == 3)
                {
                    fenceprefab.transform.localScale = new Vector3(fencethiccness, randomfenceheight, 0);
                    Instantiate(fenceprefab, new Vector3(7.555f, -1.3f, -5), Quaternion.identity);
                    // yield return new WaitForSeconds(5.0f);
                }
                if (randomfenceheight == 2)
                {
                    fenceprefab.transform.localScale = new Vector3(fencethiccness, randomfenceheight, 0);
                    Instantiate(fenceprefab, new Vector3(7.555f, -1.0f, -5), Quaternion.identity);
                    //yield return new WaitForSeconds(5.0f);
                }
                if (randomfenceheight == 1)
                {
                    fenceprefab.transform.localScale = new Vector3(fencethiccness, randomfenceheight, 0);
                    Instantiate(fenceprefab, new Vector3(7.555f, -0.75f, -5), Quaternion.identity);
                    //yield return new WaitForSeconds(5.0f);
                }
                //need to readjust y positions
                //Instantiate(new Vector3(), Quaternion.identity);
                //yield return new WaitForSeconds(5.0f);
            }
        }
    }
}
