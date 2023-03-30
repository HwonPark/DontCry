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
        text.text = "비 맞으며 놀다가 엄마한테 혼났다 ㅜ\n바로 울음이 나와 Don't Cry 실패!!!\n엔터 눌러 엔딩 보러 가기";
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
        text.text = "비오는데 밖을 나가다니 아주 아주 나빠 집에서 놀아야지 ㅎㅎ\n 게이지 2 다운\n 엔터 눌러 다음 미션으로";
        if (Input.GetKeyDown(KeyCode.Return))
        {
            tearGauge.value -= 0.2f;
            list.GetComponent<Text>().text = "Mission list\n- 과자 찾기 게임\n- 우유 선택 게임\n-줄넘기";
            SceneManager.LoadScene("Day2_Bedroom2");
        }
    }
}
