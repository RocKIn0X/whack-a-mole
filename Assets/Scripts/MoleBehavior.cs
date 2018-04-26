using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoleBehavior : MonoBehaviour {
    public float MAX_TIME = 15f;
    public float MIN_TIME = 5f;
    public ScoreManager scoreManager;

    private float spawnTime;
    private float time = 0f;

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
            animator.SetBool("Hit1", false);
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
            animator.SetBool("Hit1", true);
            scoreManager.UpdateScore();
        }
    }
}
