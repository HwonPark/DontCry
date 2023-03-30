using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayOrNot : MonoBehaviour
{
    public int i ;
    
    // Start is called before the first frame update
    void Start()
    {
        i = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (i == 0)
        {
            SceneManager.LoadScene("NotPlayThree");
            Debug.Log("������ �ȳ�� ������");


        }
        else if (i == 1)
        {
            SceneManager.LoadScene("PlayThree");
            Debug.Log("������ ��� ������");
        }
    }

    public void OnClickNotPlay()
    {
        i = 0;
        SceneManager.LoadScene("NotPlayThree");
        Debug.Log("������ �ȳ�� ������");

    }
    public void OnClickPlay()
    {
        i = 1;
        SceneManager.LoadScene("PlayThree");
        Debug.Log("������ ��� ������");

    }
}
