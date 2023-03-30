using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class rainmission : MonoBehaviour
{
    public Slider tearGauge;
    public GameObject talkpanel;
    public Text text;
    public GameObject list;
    public GameObject day;
    // Start is called before the first frame update
    void Start()
    {
        tearGauge = Slider.FindObjectOfType<Slider>();
        text.text = "";
        talkpanel.SetActive(false);
        list = GameObject.FindGameObjectWithTag("list");
        day = GameObject.FindGameObjectWithTag("day");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ClickB1()
    {
        talkpanel.SetActive(true);
        text.text = "�� ������ ��ٰ� �������� ȥ���� ��\n�ٷ� ������ ���� Don't Cry ����!!!\n���� ���� ���� ���� ����";
        if (Input.GetKeyDown(KeyCode.Return))
        {
            list.GetComponent<Text>().text = "";
            day.GetComponent<Text>().text = "";
            SceneManager.LoadScene("BadEnding");
        }
    }
    public void ClickB2()
    {
        talkpanel.SetActive(true);
        text.text = "����µ� ���� �����ٴ� ���� ���� ���� ������ ��ƾ��� ����\n ������ 2 �ٿ�\n ���� ���� ���� �̼�����";
        if (Input.GetKeyDown(KeyCode.Return))
        {
            tearGauge.value -= 0.2f;
            list.GetComponent<Text>().text = "Mission list\n- ���� ã�� ����\n- ���� ���� ����\n-�ٳѱ�";
            SceneManager.LoadScene("Day2_Bedroom2");
        }
    }
}
