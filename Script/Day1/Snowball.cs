using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowball : MonoBehaviour
{
    public float speed;

    public Vector3 rotate_V;
    public Vector3 scale_v;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Rotate(Vector3.right * speed * Time.deltaTime, Space.World);
            scale_v.x = 1f;

            transform.localScale += scale_v;
            
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Rotate(Vector3.left * speed * Time.deltaTime, Space.World);
            scale_v.x = 1f;
            transform.localScale += scale_v;
            
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.forward * speed * Time.deltaTime, Space.World);
            scale_v.y = 1f;
            transform.localScale += scale_v;
            
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.back * speed * Time.deltaTime, Space.World);
            scale_v.y = 1f;
            transform.localScale += scale_v;
            
        }
    }

}
