using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class HitmanController : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform shootPoint;
    Vector3 mousePosition;
    int power = 3000;

    float xAngle = 0;
    float yAngle = 0;

    void Update()
    {
        if (Input.anyKeyDown == false)
        {
            xAngle = 0;
            yAngle = 0;
        }
        LeftRotation();
        RightRotation();
        UpRotation();
        DownRotation();

        transform.Rotate(xAngle, yAngle, 0);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet = GameObject.Instantiate(bulletPrefab);
        bullet.transform.position = shootPoint.transform.position;
        Debug.Log(transform.forward);
        bullet.GetComponent<Rigidbody>().AddForce(transform.forward * power);
    }

    void LeftRotation()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            yAngle = -20f * Time.deltaTime;
        }
    }
    void RightRotation()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            yAngle = 20f * Time.deltaTime;
        }
    }
    void UpRotation()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            xAngle = -20f * Time.deltaTime;
        }
    }
    void DownRotation()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            xAngle = 20f * Time.deltaTime;
        }
    }
}
