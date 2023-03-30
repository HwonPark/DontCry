using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class snowballgame : MonoBehaviour
{
    public Slider tearGauge;
    public GameObject list;
    public GameObject buttonR;
    public GameObject buttonL;
    public Text Scripttxt;
    public Text ending;
    private int r;
    private int c1, c2, c3, c4,c5;
    private int weight;
    int count;

    void Start ()
    {
        tearGauge = Slider.FindObjectOfType<Slider>();
        list = GameObject.FindGameObjectWithTag("list");
        r = Random.Range(0,401);
        c1 = Random.Range(20, 51);
        c2 = Random.Range(20, 51);
        c3 = Random.Range(20, 51);
        c4 = Random.Range(20, 51);
        c5 = Random.Range(20, 51);
        weight = 200;
        Scripttxt.text = "";
        ending.text = "";
        Debug.Log("r is "+r);
     
    }
    // Start is called before the first frame update
    public void changeweight()
    {
        if (count == 0)
        {
            weight += c1;
            textupdate();
        }
         else if (count == 1)
        {
            weight += c2;
            textupdate();
        }
        else if (count == 2)
        {
            weight += c3;
            textupdate();
        }
        else if (count == 3)
        {
            weight += c4;
            textupdate();
        }
        else if (count == 4)
        {
            weight += c5;
            textupdate();
        }

        Debug.Log("weightup");
        Debug.Log(weight);
        count++;
    }
    public void changeweight2()
    {
        if (count == 0)
        {
            weight -= c1;
            textupdate();
        }
        else if (count == 1)
        {
            weight -= c2;
            textupdate();
        }
        else if (count == 2)
        {
            weight -= c3;
            textupdate();
        }
        else if (count == 3)
        {
            weight -= c4;
            textupdate();
        }
        else if (count == 4)
        {
            weight -= c5;
            textupdate();
        }
        Debug.Log("weightdown");
        count++;
        Debug.Log(count);
        Debug.Log(weight);
    }
    void textupdate()
    {
        if(weight > r)
        {
            Scripttxt.text = "      down";
        }
        else
        {
            Scripttxt.text = "        up";
        }
       
    }
    void Update()
    {
        if (count ==5)
        {
            if (weight >= r - 20 && weight <= r + 20)
            {
                Scripttxt.text = "";

                ending.text = "성공!           눈물 게이지가      1 떨어졌습니다! 엔터 눌러     미션 마치기";
                if (Input.GetKeyDown(KeyCode.Return))
                {
                    tearGauge.value -= 0.1f;
                    SceneManager.LoadScene("Day3_End");
                }
            }
            else
            {
                Scripttxt.text = "";
                ending.text = "실패!           눈물 게이지가      3 올라갔습니다! 엔터 눌러     미션 마치기";
                if (Input.GetKeyDown(KeyCode.Return))
                {
                    tearGauge.value += 0.3f;
                    SceneManager.LoadScene("Day3_End");
                }
            }
            
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("Day3_End");
        }
    }
}
