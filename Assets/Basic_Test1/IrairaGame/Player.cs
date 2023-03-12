using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float speed = 5f;
    GameObject GameOverText;
    GameObject GameClearText;

    // Start is called before the first frame update
    void Start()
    {
        GameOverText = GameObject.Find("GameOverText");
        GameClearText = GameObject.Find("GameClearText");
        GameOverText.SetActive(false);
        GameClearText.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Movement(0, speed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Movement(0, -speed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Movement(-speed, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Movement(speed, 0);
        }
    }

    void Movement(float x, float y)
    {

        float _x = x * Time.deltaTime;
        float _y = y * Time.deltaTime;

        Debug.Log(_x + "&" + x);
        transform.Translate(_x, _y, 0);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Goal")
        {
            GameClearText.SetActive(true);
        }
        else
        {
            GameOverText.SetActive(true);
        }
    }

}