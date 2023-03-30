using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class milkgame : MonoBehaviour
{
    public Slider tearGauge;
    public int ran;
    public int f = 10;
    public GameObject talkpanel;
    public Text text;
    public GameObject list;
    // Start is called before the first frame update
    void Start()
    {
        tearGauge = Slider.FindObjectOfType<Slider>();
        ran = Random.Range(1, 4);
        f = 10;
        text.text = "";
        talkpanel.SetActive(false);
        list = GameObject.FindGameObjectWithTag("list");
    }

    // Update is called once per frame
    void Update()
    {
        if (f == 1)
        {
            //SceneManager.LoadScene("SuccessFind");

            talkpanel.SetActive(true);
            text.text = "오 맛있는거 고름\n게이지 -1 감소\n엔터눌러서 미션 마치기";
            if (Input.GetKeyDown(KeyCode.Return))
            {
                tearGauge.value -= 0.1f;
                list.GetComponent<Text>().text = "Mission list\n-줄넘기";
                SceneManager.LoadScene("Day2_LivingroomKitchen3");
            }
        }
        else if (f == 0)
        {
            //SceneManager.LoadScene("FailToFind");

            talkpanel.SetActive(true);
            text.text = "웩 맛없어 !\n게이지 +3 증가\n엔터눌러서 미션 마치기";
            if (Input.GetKeyDown(KeyCode.Return))
            {
                tearGauge.value += 0.3f;
                list.GetComponent<Text>().text = "Mission list\n-줄넘기";
                SceneManager.LoadScene("Day2_LivingroomKitchen3");
            }
        }
    }

    public void ClickB1()
    {
        if (ran == 1)
        {
            f = 1;
            Debug.Log("버튼1");
        }
        else
        {
            f = 0;
            Debug.Log("버튼1");
        }
    }

    public void ClickB2()
    {
        if (ran == 2)
        {
            f = 1;
            Debug.Log("버튼2");
        }
        else
        {
            f = 0;
            Debug.Log("버튼2");
        }
    }

    public void ClickB3()
    {
        if (ran == 3)
        {
            f = 1;
            Debug.Log("버튼3");
        }
        else
        {
            f = 0;
            Debug.Log("버튼3");
        }
    }
}
