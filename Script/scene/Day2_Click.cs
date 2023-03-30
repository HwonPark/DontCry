using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Day2_Click : MonoBehaviour
{
    public void EnterBedroom2ToLivingroomKitchen1()
    {
        SceneManager.LoadScene("Day2_LivingroomKitchen1");
    }
    public void EnterSnackGame()
    {
        SceneManager.LoadScene("FindSnack2");
    }
    public void EnterMilkGame()
    {
        SceneManager.LoadScene("Milk2");
    }
    public void EnterGarden()
    {
        SceneManager.LoadScene("Day2_Garden1");
    }
    public void EnterjumpGame()
    {
        SceneManager.LoadScene("jumprope");
    }
}
