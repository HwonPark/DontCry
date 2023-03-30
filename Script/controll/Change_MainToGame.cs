using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Game Intro --> Game Screen
public class Change_MainToGame : MonoBehaviour
{
    public void RollingGameStart()
    {
        SceneManager.LoadScene("RollingSnowball_GameScreen");
    }

    public void ArrangeGameIntro()
    {
        SceneManager.LoadScene("ArrangeRoom_GameIntro");
    }

    public void ArrangeGameStart()
    {
        SceneManager.LoadScene("ArrangeRoom_GameScreen");
    }
}
