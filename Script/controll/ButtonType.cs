using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonType : MonoBehaviour
{
    public BTNtype currentType;
    public void OnButtonClick()
    {
        switch(currentType)
        {
            case BTNtype.GameStart:
                Debug.Log("게임 시작");
                SceneManager.LoadScene("Day1_Bedroom1");
                break;
            case BTNtype.GameContinue:
                Debug.Log("집 둘러보기");
                SceneManager.LoadScene("Home_LivingroomKitchen");
                break;
            case BTNtype.GameExit:
                Debug.Log("게임 종료");
                Application.Quit();
                break;
        }
    }
}
