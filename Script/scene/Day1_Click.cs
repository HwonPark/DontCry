using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Day1_Click : MonoBehaviour
{
    public void EnterBedroom2ToLivingroomKitchen1()
    {
        SceneManager.LoadScene("Day1_LivingroomKitchen1");
    }

    public void EnterSnackGame()
    {
        SceneManager.LoadScene("FindSnackScene");
    }

    public void EnterLivingroomToGarden1()
    {
        SceneManager.LoadScene("Day1_Garden1");
    }
}
