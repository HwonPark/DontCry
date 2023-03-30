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
            text.text = "�� ���ִ°� ��\n������ -1 ����\n���ʹ����� �̼� ��ġ��";
            if (Input.GetKeyDown(KeyCode.Return))
            {
                tearGauge.value -= 0.1f;
                list.GetComponent<Text>().text = "Mission list\n-�ٳѱ�";
                SceneManager.LoadScene("Day2_LivingroomKitchen3");
            }
        }
        else if (f == 0)
        {
            //SceneManager.LoadScene("FailToFind");

            talkpanel.SetActive(true);
            text.text = "�� ������ !\n������ +3 ����\n���ʹ����� �̼� ��ġ��";
            if (Input.GetKeyDown(KeyCode.Return))
            {
                tearGauge.value += 0.3f;
                list.GetComponent<Text>().text = "Mission list\n-�ٳѱ�";
                SceneManager.LoadScene("Day2_LivingroomKitchen3");
            }
        }
    }

    public void ClickB1()
    {
        if (ran == 1)
        {
            f = 1;
            Debug.Log("��ư1");
        }
        else
        {
            f = 0;
            Debug.Log("��ư1");
        }
    }

    public void ClickB2()
    {
        if (ran == 2)
        {
            f = 1;
            Debug.Log("��ư2");
        }
        else
        {
            f = 0;
            Debug.Log("��ư2");
        }
    }

    public void ClickB3()
    {
        if (ran == 3)
        {
            f = 1;
            Debug.Log("��ư3");
        }
        else
        {
            f = 0;
            Debug.Log("��ư3");
        }
    }
}
