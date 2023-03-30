using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FindSnackGame : MonoBehaviour
{
    public Slider tearGauge;
    public Text ending;
    public Text fail;
    public int ran;
    public int f = 10;
    public GameObject list;
    // Start is called before the first frame update
    void Start()
    {
        list = GameObject.FindGameObjectWithTag("list");
        tearGauge = Slider.FindObjectOfType<Slider>();
        ran = Random.Range(1, 11);
        Debug.Log("����" + ran);
        f = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if (f == 1)
        {
            Debug.Log("ã�Ҵ� �� ����");
            fail.text = "";
            ending.text = "ã�Ҵ� �� ���� ! ���� Ű�� ���� �����Ͻÿ�.";
            if (Input.GetKey(KeyCode.Return))
            {
                tearGauge.value -= 0.1f;
                list.GetComponent<Text>().text = "Mission list\n- �������� ����";
                SceneManager.LoadScene("Day1_LivingroomKitchen3");
            }

        }
        else if (f == 0)
        {
            Debug.Log("��𰬳� �� ����");
            ending.text = "";
            fail.text = "��𰬳� �� ���� !";
        }
    }




    public void ClickB1()
    {
        if (ran == 1)
        {
            f = 1;
            Debug.Log("��ư1");
        }
        else
        {
            f = 0;
            Debug.Log("��ư1");
        }
    }

    public void ClickB2()
    {
        if (ran == 2)
        {
            f = 1;
            Debug.Log("��ư2");
        }
        else
        {
            f = 0;
            Debug.Log("��ư2");
        }
    }

    public void ClickB3()
    {
        if (ran == 3)
        {
            f = 1;
            Debug.Log("��ư3");
        }
        else
        {
            f = 0;
            Debug.Log("��ư3");
        }
    }

    public void ClickB4()
    {
        if (ran == 4)
        {
            f = 1;
            Debug.Log("��ư4");
        }
        else
        {
            f = 0;
            Debug.Log("��ư4");
        }
    }

    public void ClickB5()
    {
        if (ran == 5)
        {
            f = 1;
            Debug.Log("��ư5");
        }
        else
        {
            f = 0;
            Debug.Log("��ư5");
        }
    }

    public void ClickB6()
    {
        if (ran == 6)
        {
            f = 1;
            Debug.Log("��ư6");
        }
        else
        {
            f = 0;
            Debug.Log("��ư6");
        }
    }
    public void ClickB7()
    {
        if (ran == 7)
        {
            f = 1;
            Debug.Log("��ư7");
        }
        else
        {
            f = 0;
            Debug.Log("��ư7");
        }
    }
    public void ClickB8()
    {
        if (ran == 8)
        {
            f = 1;
            Debug.Log("��ư8");
        }
        else
        {
            f = 0;
            Debug.Log("��ư8");
        }
    }
    public void ClickB9()
    {
        if (ran == 9)
        {
            f = 1;
            Debug.Log("��ư9");
        }
        else
        {
            f = 0;
            Debug.Log("��ư9");
        }
    }
    public void ClickB10()
    {
        if (ran == 10)
        {
            f = 1;
            Debug.Log("��ư10");
        }
        else
        {
            f = 0;
            Debug.Log("��ư10");
        }
    }
}
