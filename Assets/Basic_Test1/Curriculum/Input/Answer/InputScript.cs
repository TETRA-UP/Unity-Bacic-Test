using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(KeyCode.UpArrow);
        //Debug.Log((int)KeyCode.UpArrow);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Input.GetKey(KeyCode.UpArrow));
        //Debug.Log(Input.GetKey((KeyCode)273));

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("キーが押された");
        }
    }
}
