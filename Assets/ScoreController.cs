using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreController : MonoBehaviour {

    private GameObject scoreText;
    public int score;
    // Use this for initialization
    void Start () {
        this.scoreText = GameObject.Find("ScoreText");
        score = 0;
	}
	
	// Update is called once per frame
	void Update () {
        scoreText.GetComponent<Text>().text = "Score:" +  score;

		
	}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "SmallStarTag")
        {
            score += 10;
        } else if (collision.gameObject.tag == "LargeStarTag")
        {
            score += 20;
        } else if (collision.gameObject.tag == "SmallCloudTag")
        {
            score += 30;
        } else if (collision.gameObject.tag == "LargeCloudTag")
        {
            score += 40;
        }
    }
}
