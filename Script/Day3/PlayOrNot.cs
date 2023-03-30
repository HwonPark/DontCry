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
            Debug.Log("¾²¸®¶û ¾È³î¾Æ ¼±ÅÃÁö");


        }
        else if (i == 1)
        {
            SceneManager.LoadScene("PlayThree");
            Debug.Log("¾²¸®¶û ³î¾Æ ¼±ÅÃÁö");
        }
    }

    public void OnClickNotPlay()
    {
        i = 0;
        SceneManager.LoadScene("NotPlayThree");
        Debug.Log("¾²¸®¶û ¾È³î¾Æ ¼±ÅÃÁö");

    }
    public void OnClickPlay()
    {
        i = 1;
        SceneManager.LoadScene("PlayThree");
        Debug.Log("¾²¸®¶û ³î¾Æ ¼±ÅÃÁö");

    }
}
