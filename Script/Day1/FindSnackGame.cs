using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FindSnackGame : MonoBehaviour
{
    public Slider tearGauge;
    public Text ending;
    public Text fail;
    public int ran;
    public int f = 10;
    public GameObject list;
    // Start is called before the first frame update
    void Start()
    {
        list = GameObject.FindGameObjectWithTag("list");
        tearGauge = Slider.FindObjectOfType<Slider>();
        ran = Random.Range(1, 11);
        Debug.Log("난수" + ran);
        f = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if (f == 1)
        {
            Debug.Log("찾았다 내 과자");
            fail.text = "";
            ending.text = "찾았다 내 과자 ! 엔터 키를 눌러 종료하시오.";
            if (Input.GetKey(KeyCode.Return))
            {
                tearGauge.value -= 0.1f;
                list.GetComponent<Text>().text = "Mission list\n- 눈굴리기 게임";
                SceneManager.LoadScene("Day1_LivingroomKitchen3");
            }

        }
        else if (f == 0)
        {
            Debug.Log("어디갔냐 내 과자");
            ending.text = "";
            fail.text = "어디갔냐 내 과자 !";
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

    public void ClickB4()
    {
        if (ran == 4)
        {
            f = 1;
            Debug.Log("버튼4");
        }
        else
        {
            f = 0;
            Debug.Log("버튼4");
        }
    }

    public void ClickB5()
    {
        if (ran == 5)
        {
            f = 1;
            Debug.Log("버튼5");
        }
        else
        {
            f = 0;
            Debug.Log("버튼5");
        }
    }

    public void ClickB6()
    {
        if (ran == 6)
        {
            f = 1;
            Debug.Log("버튼6");
        }
        else
        {
            f = 0;
            Debug.Log("버튼6");
        }
    }
    public void ClickB7()
    {
        if (ran == 7)
        {
            f = 1;
            Debug.Log("버튼7");
        }
        else
        {
            f = 0;
            Debug.Log("버튼7");
        }
    }
    public void ClickB8()
    {
        if (ran == 8)
        {
            f = 1;
            Debug.Log("버튼8");
        }
        else
        {
            f = 0;
            Debug.Log("버튼8");
        }
    }
    public void ClickB9()
    {
        if (ran == 9)
        {
            f = 1;
            Debug.Log("버튼9");
        }
        else
        {
            f = 0;
            Debug.Log("버튼9");
        }
    }
    public void ClickB10()
    {
        if (ran == 10)
        {
            f = 1;
            Debug.Log("버튼10");
        }
        else
        {
            f = 0;
            Debug.Log("버튼10");
        }
    }
}
