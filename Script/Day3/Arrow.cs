using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public float speed = 40;

    // Update is called once per frame
    void Update()
    {
        transform.localPosition += Vector3.right * speed * Time.deltaTime;
    }
}
