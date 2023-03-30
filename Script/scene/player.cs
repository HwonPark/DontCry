using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed;
    public float Rspeed;
    Animator anim;
    Vector3 moveVec;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    
    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        moveVec = new Vector3(h, 0, v);
        anim.SetBool("is walk", moveVec != Vector3.zero);
        
       
       
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(Vector3.down * speed * Time.deltaTime);
            
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(Vector3.up * speed * Time.deltaTime);
          
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
           
            if (v >= 0)
            {
                this.transform.Rotate(0, 0, -speed * Rspeed * Time.deltaTime);
            }
            else
            {
                this.transform.Rotate(0, 0, speed * Rspeed * Time.deltaTime);
            }
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
           
            if (v >= 0)
            {
                this.transform.Rotate(0, 0, speed * Rspeed * Time.deltaTime);
            }else
            {
                this.transform.Rotate(0, 0, -speed * Rspeed * Time.deltaTime);
            }
        }
    }

}
