using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    public GameObject mess;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - mess.transform.position;
    }
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = mess.transform.position + offset;
    }
}
