using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartDontCry : MonoBehaviour
{
    public bool a = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (a == true)
        {
            SceneManager.LoadScene("Bedroom");


        }
    }

    public void OnClickPlay()
    {
        a = true;
        Debug.Log("게임시작");

    }
}
