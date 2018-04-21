using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleBehavior : MonoBehaviour {
    public float MAX_TIME = 15f;
    public float MIN_TIME = 5f;
    private float spawnTime;
    private float showTime = 3f;
    private float time = 0f;
    private string state = "HIDE";

	// Use this for initialization
	void Start () {
        spawnTime = Random.Range(MIN_TIME, MAX_TIME);
	}
	
	// Update is called once per frame
	void Update () {
        if (state == "HIDE")
        {
            if (time >= spawnTime)
            {
                transform.position += new Vector3(0f, 1f, 0f);
                time = 0;
                state = "SHOW";
            }
        } else if (state == "SHOW") {
            if (time >= showTime)
            {
                transform.position -= new Vector3(0f, 1f, 0f);
                time = 0;
                spawnTime = Random.Range(MIN_TIME, MAX_TIME);
                state = "HIDE";
            }
        }
        time += Time.deltaTime;
    }
}
