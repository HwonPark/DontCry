using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ThreeIsWalking : MonoBehaviour
{
    void WalkingThree()
    {
        int walkingSpeed = 2;
        while(true)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(1, 1, 0), Time.deltaTime * walkingSpeed);
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(-1, -1, 0), Time.deltaTime * walkingSpeed);
        }

    }

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        WalkingThree();
    }

}
