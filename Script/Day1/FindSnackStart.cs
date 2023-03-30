using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FindSnackStart : MonoBehaviour
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
            SceneManager.LoadScene("FindSnackScene");


        }
    }

    public void OnClickFind()
    {
        a = true;
        Debug.Log("과자찾기시작");

    }
}
