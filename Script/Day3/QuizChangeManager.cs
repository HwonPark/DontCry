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
        Debug.Log("1�� ���� �����Դϴ�");
        SceneManager.LoadScene("MathQuiz2");
    }
    public void StartQuiz2_wrongAnswer()
    {
        DelayTime();
        MissionGauge = MissionGauge + 2;
        Debug.Log("1�� ���� �����Դϴ�");
        SceneManager.LoadScene("MathQuiz2");
    }

    public void StartQuiz3_rightAnswer()
    {
        DelayTime();
        MissionGauge--;
        Debug.Log("2�� ���� �����Դϴ�");
        SceneManager.LoadScene("MathQuiz3");
    }
    public void StartQuiz3_wrongAnswer()
    {
        DelayTime();
        MissionGauge = MissionGauge + 2;
        Debug.Log("2�� ���� �����Դϴ�");
        SceneManager.LoadScene("MathQuiz3");
    }

    public void endQuiz_rightAnswer()
    {
        DelayTime();
        MissionGauge--;
        Debug.Log("3�� ���� �����Դϴ�");
        if( MissionGauge > 3 )
        {
            tearGauge.value -= 0.3f;
        }
        if (MissionGauge <= 3)
        {
            tearGauge.value += 0.3f;
        }
        list.GetComponent<Text>().text = "Mission list\n- ����� �����";
        SceneManager.LoadScene("Day3_LivingroomKitchen3");
    }
    public void endQuiz_wrongAnswer()
    {
        DelayTime();
        MissionGauge = MissionGauge + 2;
        Debug.Log("3�� ���� �����Դϴ�");
        if (MissionGauge > 3)
        {
            tearGauge.value -= 0.3f;
        }
        if (MissionGauge <= 3)
        {
            tearGauge.value += 0.3f;
        }
        list.GetComponent<Text>().text = "Mission list\n- ����� �����";
        SceneManager.LoadScene("Day3_LivingroomKitchen3");
    }

}
