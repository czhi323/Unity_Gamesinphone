using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movetest : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log(Time.deltaTime + "");
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y <= -6.0)
        {
            Destroy(this);
        }

        transform.Translate(0, (float)-0.02 * 2, 0,Space.World);
        //transform.Translate(Vector3.down * Time.deltaTime, Camera.main.transform);
        //transform.position +=new Vector3(0,-Time.deltaTime * 2);
       // transform.Translate(new Vector3(0, -Time.deltaTime * 2, 0));
    }
}
