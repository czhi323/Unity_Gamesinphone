using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button_event : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void btn_toGameanimal()
    {
        SceneManager.LoadScene("first");
    }
    public void btn_toGamestarwar()
    {
        SceneManager.LoadScene("starwar");
    }
    public void btn_toGamefruit()
    {
        SceneManager.LoadScene("fruit");

    }
}
