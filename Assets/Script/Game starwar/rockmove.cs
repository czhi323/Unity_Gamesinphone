using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockmove : MonoBehaviour {
    public float speed = 5;

	// Use this for initialization
	void Start () {
        

    }
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y <= -6.0)
        {
            Destroy(this.gameObject);
        }
            
        transform.Translate(0, (float)-0.02 * speed, 0, Space.Self);

    }

}
