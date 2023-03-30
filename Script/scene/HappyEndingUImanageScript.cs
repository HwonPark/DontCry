using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HappyEndingUImanageScript : MonoBehaviour
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
        day.GetComponent<Text>().text = "크리스마스";
        if (Input.GetMouseButtonDown(0))
        {
            if (clickCount == 0)
            {
                Debug.Log("대화1");
                talkPanel.SetActive(true);
                text.text = "안녕 아가? 메리 크리스마스!\n즐거운 겨울을 보내고 있는 것 같구나.";
                clickCount++;
            }
            else if (clickCount == 1)
            {
                Debug.Log("대화2");
                talkPanel.SetActive(true);

                text.text = "울지 않고 착한 아이에게는 선물을 줘야지.";
                clickCount++;
            }
            else if (clickCount == 2)
            {
                Debug.Log("대화3");
                talkPanel.SetActive(true);
                text.text = "마음에 들었으면 좋겠구나. 내년에도 웃는 얼굴로 만나자.";
                clickCount++;
            }
            else if (clickCount == 3)
            {
                Debug.Log("대화 종료");
                quit.text = "종료";
                talkPanel.SetActive(false);
            }

        }
    }
}
