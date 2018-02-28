using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animalscript : MonoBehaviour {
    private float livetime ;

    // Use this for initialization
    void Start () {
        livetime = Time.time + 1;
    }
	
	// Update is called once per frame
	void Update () {
        if (Time.time > livetime)
            Destroy(this.gameObject);
	}
    


}
