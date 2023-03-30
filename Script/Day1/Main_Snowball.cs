using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Snowball : MonoBehaviour
{
    public GameObject center;
    public float speed;
    Vector3 rotate_v;

    
    void Update()
    {
        rotate_v.x = -1 * speed * Time.deltaTime;
        transform.RotateAround(center.transform.position, Vector3.up, speed * Time.deltaTime);
        transform.Rotate(rotate_v);
    }
}
