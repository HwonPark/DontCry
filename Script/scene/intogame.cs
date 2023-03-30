using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class intogame : MonoBehaviour
{
    public GameObject btn;
    // Start is called before the first frame update
    void Start()
    {
        btn.gameObject.SetActive(false);
    }

    // Update is called once per frame
   

    private void OnTriggerEnter(Collider other)
    {

        btn.gameObject.SetActive(true);

    }
    private void OnTriggerExit(Collider other)
    {
        btn.gameObject.SetActive(false);
    }
}
