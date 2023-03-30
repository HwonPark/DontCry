using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizChangeManager : MonoBehaviour
{
    int MissionGauge = 0;
    public GameObject Answer;
    public Slider tearGauge;
    public GameObject list;


    void Start()
    {
        tearGauge = Slider.FindObjectOfType<Slider>();
        list = GameObject.FindGameObjectWithTag("list");
    }


    IEnumerator DelayTime()
    {
        yield return new WaitForSeconds(3);
    }
    

    public void StartQuizScene()
    {
        SceneManager.LoadScene("MathQuiz1");
    }

    public void StartQuiz2_rightAnswer()
    {
        DelayTime();
        MissionGauge--;
        Debug.Log("1번 문제 정답입니다");
        SceneManager.LoadScene("MathQuiz2");
    }
    public void StartQuiz2_wrongAnswer()
    {
        DelayTime();
        MissionGauge = MissionGauge + 2;
        Debug.Log("1번 문제 오답입니다");
        SceneManager.LoadScene("MathQuiz2");
    }

    public void StartQuiz3_rightAnswer()
    {
        DelayTime();
        MissionGauge--;
        Debug.Log("2번 문제 정답입니다");
        SceneManager.LoadScene("MathQuiz3");
    }
    public void StartQuiz3_wrongAnswer()
    {
        DelayTime();
        MissionGauge = MissionGauge + 2;
        Debug.Log("2번 문제 오답입니다");
        SceneManager.LoadScene("MathQuiz3");
    }

    public void endQuiz_rightAnswer()
    {
        DelayTime();
        MissionGauge--;
        Debug.Log("3번 문제 정답입니다");
        if( MissionGauge > 3 )
        {
            tearGauge.value -= 0.3f;
        }
        if (MissionGauge <= 3)
        {
            tearGauge.value += 0.3f;
        }
        list.GetComponent<Text>().text = "Mission list\n- 눈사람 만들기";
        SceneManager.LoadScene("Day3_LivingroomKitchen3");
    }
    public void endQuiz_wrongAnswer()
    {
        DelayTime();
        MissionGauge = MissionGauge + 2;
        Debug.Log("3번 문제 오답입니다");
        if (MissionGauge > 3)
        {
            tearGauge.value -= 0.3f;
        }
        if (MissionGauge <= 3)
        {
            tearGauge.value += 0.3f;
        }
        list.GetComponent<Text>().text = "Mission list\n- 눈사람 만들기";
        SceneManager.LoadScene("Day3_LivingroomKitchen3");
    }

}
