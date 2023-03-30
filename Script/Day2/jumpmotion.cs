using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpmotion : MonoBehaviour
{
    Rigidbody rbody;
    public int force = 100;
    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rbody.AddForce(new Vector3(0, 1, 0) * force);
        }
    }
}
