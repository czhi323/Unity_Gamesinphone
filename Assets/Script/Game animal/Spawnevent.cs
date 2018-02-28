using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnevent : MonoBehaviour {
    public float spawnrate=2;
    private float spawntime;
    public GameObject animal;

    private double[][] position;
	// Use this for initialization
	void Start () {
        spawntime = Time.time;
        position = new double[][] {new double[]{-2.12,1.68}, new double[] { -0.14,1.73}, new double[] { 1.72,1.63},
                                   new double[]{-2.37,-0.5}, new double[]{-0.14,-0.63},new double[]{1.92,-0.63},
                                   new double[]{-2.54,-3},new double[]{-0.22,-3.2},new double[]{1.97,-3.1} };
    }
	
	// Update is called once per frame
	void Update () {
        if(Time.time>spawntime)
        {
            var index= Random.Range(0, 8);
            Instantiate(animal, new Vector3((float)position[index][0], (float)position[index][1], -1), Quaternion.Euler(0, 180, 0));
            spawntime = Time.time + spawnrate;
        }
    }
}
