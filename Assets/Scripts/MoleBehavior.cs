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

    Animator animator;

	// Use this for initialization
	void Start () {
        spawnTime = Random.Range(MIN_TIME, MAX_TIME);
        animator = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("idle 1"))
        {
            time += Time.deltaTime;
        }

        if (time >= spawnTime)
        {
            animator.SetTrigger("Show");
            time = 0f;
            spawnTime = Random.Range(MIN_TIME, MAX_TIME);
        }
    }

    private void OnMouseDown()
    {
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("idle"))
        {
            print("Hit");
            animator.SetTrigger("Hit");
        }
    }
}
