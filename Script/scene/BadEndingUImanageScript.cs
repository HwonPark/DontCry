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
        day.GetComponent<Text>().text = "크리스마스";
        if (Input.GetMouseButtonDown(0))
        {
            if (clickCount == 0)
            {
                Debug.Log("대화1");
                talkPanel.SetActive(true);
                text.text = "안녕 아가? 메리 크리스마스!\n그런데 너...최근에 운 적이 있구나.";
                clickCount++;
            }
            else if (clickCount == 1)
            {
                Debug.Log("대화2");
                talkPanel.SetActive(true);

                text.text = "뺨에 눈물이 지나간 길이 선명해. 내 눈은 속일 수 없지.";
                clickCount++;
            }
            else if (clickCount == 2)
            {
                Debug.Log("대화3");
                talkPanel.SetActive(true);
                text.text = "아쉽지만 선물을 줄 순 없겠구나...\n아버지 또한 너만의 산타이시니 너무 속상해하지는 마렴.";
                clickCount++;
            }
            else if (clickCount == 3)
            {
                Debug.Log("대화4");
                talkPanel.SetActive(true);
                text.text = "내년에는 웃는 얼굴로 만나자.";
                clickCount++;
            }
            else if (clickCount == 4)
            {
                Debug.Log("대화 종료");
                quit.text = "종료";
                talkPanel.SetActive(false);            }

        }
    }
}
