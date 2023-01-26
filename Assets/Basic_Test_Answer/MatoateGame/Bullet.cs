using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Bullet : MonoBehaviour
{
    GameObject ScoreText;
    ScoreController scoreController;

    // Start is called before the first frame update
    void Start()
    {
        ScoreText = GameObject.Find("ScoreText");
        Debug.Log(ScoreText);
        scoreController = ScoreText.GetComponent<ScoreController>();
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Target")
        {
            scoreController.score += 1;
            Destroy(other.gameObject);
        }
    }
}
