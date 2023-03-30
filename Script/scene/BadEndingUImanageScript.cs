using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BadEndingUImanageScript : MonoBehaviour
{
    public GameObject talkPanel;
    public Text text;
    [SerializeField]
    public Text quit;
    int clickCount = 0;
    public GameObject list;
    public GameObject day;

    void Start()
    {
        talkPanel.SetActive(false);
        text.text = "";
        list = GameObject.FindGameObjectWithTag("list");
        day = GameObject.FindGameObjectWithTag("day");
    }

    void Update()
    {
        list.GetComponent<Text>().text = "";
        day.GetComponent<Text>().text = "ũ��������";
        if (Input.GetMouseButtonDown(0))
        {
            if (clickCount == 0)
            {
                Debug.Log("��ȭ1");
                talkPanel.SetActive(true);
                text.text = "�ȳ� �ư�? �޸� ũ��������!\n�׷��� ��...�ֱٿ� �� ���� �ֱ���.";
                clickCount++;
            }
            else if (clickCount == 1)
            {
                Debug.Log("��ȭ2");
                talkPanel.SetActive(true);

                text.text = "���� ������ ������ ���� ������. �� ���� ���� �� ����.";
                clickCount++;
            }
            else if (clickCount == 2)
            {
                Debug.Log("��ȭ3");
                talkPanel.SetActive(true);
                text.text = "�ƽ����� ������ �� �� ���ڱ���...\n�ƹ��� ���� �ʸ��� ��Ÿ�̽ô� �ʹ� �ӻ��������� ����.";
                clickCount++;
            }
            else if (clickCount == 3)
            {
                Debug.Log("��ȭ4");
                talkPanel.SetActive(true);
                text.text = "���⿡�� ���� �󱼷� ������.";
                clickCount++;
            }
            else if (clickCount == 4)
            {
                Debug.Log("��ȭ ����");
                quit.text = "����";
                talkPanel.SetActive(false);            }

        }
    }
}