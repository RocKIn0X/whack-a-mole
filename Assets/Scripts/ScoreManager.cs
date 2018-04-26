using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {
    private int score;

	// Use this for initialization
	void Start () {
        score = 0;
	}

    public void UpdateScore()
    {
        score++;
    }

    public int GetScore()
    {
        return score;
    }
}
