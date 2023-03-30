using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ThreeChangeManager : MonoBehaviour
{
    public Camera GetCamera;

    public void StartQuizScene()
    {
        SceneManager.LoadScene("SnackThree");
    }

    public void giveSnack()
    {

    }

    public void endQuiz()
    {
        SceneManager.LoadScene("SnackThreeStart");
    }
}
