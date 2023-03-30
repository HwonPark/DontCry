using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowballRolling : MonoBehaviour
{
    public float speed;
    Vector3 rotate_v;

    // Update is called once per frame
    void Update()
    {
        rotate_v.x = 1 * speed * Time.deltaTime;
        transform.Rotate(rotate_v);
    }

}
