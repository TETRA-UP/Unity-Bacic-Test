using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreController : MonoBehaviour
{
    Text scoreText;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;
    }
}
