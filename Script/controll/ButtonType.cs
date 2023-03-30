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
                Debug.Log("���� ����");
                SceneManager.LoadScene("Day1_Bedroom1");
                break;
            case BTNtype.GameContinue:
                Debug.Log("�� �ѷ�����");
                SceneManager.LoadScene("Home_LivingroomKitchen");
                break;
            case BTNtype.GameExit:
                Debug.Log("���� ����");
                Application.Quit();
                break;
        }
    }
}
