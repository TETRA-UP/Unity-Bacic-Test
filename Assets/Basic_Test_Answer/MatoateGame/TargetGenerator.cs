using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class TargetGenerator : MonoBehaviour
{
    Vector3[] startPositions = new Vector3[]
    {
        new Vector3(0, 0, 0),
        new Vector3(10, 0, 0),
        new Vector3(-10, 0, 0),
        new Vector3(0, 10, 0),
        new Vector3(10, 10, 0),
        new Vector3(-10, 10, 0),
        new Vector3(0, -10, 0),
        new Vector3(10, -10, 0),
        new Vector3(-10, -10, 0),
    };


    [SerializeField]
    GameObject targetPrefab;


    // Start is called before the first frame update
    void Start()
    {
        GenerateTarget();
    }


    void GenerateTarget()
    {
        for (int i = 0; i < startPositions.Length; i++)
        {
            Instantiate(targetPrefab, startPositions[i], gameObject.transform.rotation);
        }
    }
}


//void GenerateTarget(Vector3[] vector3s, int number)
//{
//    for (int i = 0; i < number; i++)
//    {
//        //GameObject target = Instantiate(targetPrefab);
//        GameObject target = Instantiate(targetPrefab, vector3s[i], gameObject.transform.rotation);

//        //target.transform.position = new Vector3(
//        //    Random.Range(-30f, 30f),
//        //    Random.Range(-30f, 30f),
//        //    Random.Range(0f, 20f)
//        //);

//        target.transform.SetParent(gameObject.transform, false);
//        target.tag = "Target";
//    }
//}

//void GenerateTarget()
//{
//    for (int i = 0; i < startPositions.Length; i++)
//    {
//        Instantiate(targetPrefab, startPositions[i], gameObject.transform.rotation);
//    }
//}

