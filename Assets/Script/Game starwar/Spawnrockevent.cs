using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnrockevent : MonoBehaviour {
    public GameObject rock;
    private float spawnrate = 1, spawntime;
    // Use this for initialization
    void Start () {
        spawntime = Time.time;

    }
	
	// Update is called once per frame
	void Update () {
        if(Time.time>spawntime)
        {
            
            Instantiate(rock, new Vector3(Random.RandomRange(-4, 4), 6, -1), Quaternion.Euler(0, 180, 0));
            spawntime = Time.time + spawnrate;
        }
        
    }
}
