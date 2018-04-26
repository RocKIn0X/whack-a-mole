using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreHUD : MonoBehaviour {
    Text textField;

    public ScoreManager scoreManager;

    private int score;

	// Use this for initialization
	void Start () {
        textField = this.GetComponent<Text>();
        score = 0;
        textField.text = score.ToString();
	}
	
	// Update is called once per frame
	void Update () {
        score = scoreManager.GetScore();
        textField.text = score.ToString();
    }
}
