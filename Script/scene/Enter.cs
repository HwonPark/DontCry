using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Enter : MonoBehaviour {
    public GameObject list;
    public GameObject day;
    public Slider teargauge;

    void Start()
    {
        list = GameObject.FindGameObjectWithTag("list");
        day = GameObject.FindGameObjectWithTag("day");
        teargauge = Slider.FindObjectOfType<Slider>();
    }
    public void EnterGardenToHome()
    {
        SceneManager.LoadScene("Home_LivingroomKitchen");
    }
    public void EnterHomeToGarden3()
    {
        SceneManager.LoadScene("Day3_Garden1");
    }
    public void EnterHomeToGarden()
    {
        SceneManager.LoadScene("Garden");
    }
    public void EnterHomeToRoom()
    {
        SceneManager.LoadScene("Bedroom");
    }
    public void EnterRoomToLiving()
    {
        SceneManager.LoadScene("Home_LivingroomKitchen");
    }
    public void EnterToSnowballGame()
    {
        SceneManager.LoadScene("snowball");
    }
    public void EnterToJumpGame()
    {
        SceneManager.LoadScene("jumprope");
    }
    public void EnterToMilkGame()
    {
        SceneManager.LoadScene("milkchoice");
    }

    public void EnterToRollingSnow()
    {
        SceneManager.LoadScene("RollingSnowball_GameIntro");
    }
    public void EnterToDay2()
    {
        if (teargauge.value == 1f)
        {
            SceneManager.LoadScene("BadEnding");
        }
        else {
            list.GetComponent<Text>().text = "Mission list\n- 외출 선택지\n- 과자 찾기 게임\n- 우유 선택 게임\n-줄넘기";
            day.GetComponent<Text>().text = "Day 2";
            SceneManager.LoadScene("Day2_Bedroom1");
        }
        
    }

    public void EnterToDay3()
    {
        if (teargauge.value == 1f)
        {
            SceneManager.LoadScene("BadEnding");
        }
        else {
            list.GetComponent<Text>().text = "Mission list\n- 쓰리랑 놀기\n- 수학 문제 풀기\n- 눈사람 만들기";
            day.GetComponent<Text>().text = "Day 3";
            SceneManager.LoadScene("Day3_LivingroomKitchen1");
        }
        
    }

    public void Ending()
    {
        if (teargauge.value < 1f)
        {
            SceneManager.LoadScene("HappyEnding");
        }

        if (teargauge.value == 1f)
        {
            SceneManager.LoadScene("BadEnding");
        }
    }

    public void gameExit()
    {
        Application.Quit();
    }

}
