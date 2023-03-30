using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ArrowManager : MonoBehaviour
{
    public Slider tearGauge;
    public int bpm;
    double currentTime = 0d;
    public Text Endingtext;

    [SerializeField]
    Transform arrowAppear = null;
    [SerializeField]
    GameObject[] goArrow = new GameObject[4];
    [SerializeField]
    GameObject snow;
    int i;
    public int arrowNum;
    int[] array = new int[8];
    int hit;
    int fail;
    

    void Start()
    {
        tearGauge = Slider.FindObjectOfType<Slider>();
        arrowNum = 0;
        i = 0;
        hit = 0;
        fail = 0;
    }

    
    void Update()
    {
        currentTime += Time.deltaTime;
        

        if (currentTime >= 60d / bpm && arrowNum < 8)
        {
            int randomIndex = Random.Range(0, 3);
            GameObject arrow = Instantiate(goArrow[randomIndex], arrowAppear.position, Quaternion.identity);
            array[arrowNum] = randomIndex; 
            arrow.transform.SetParent(this.transform);
            currentTime -= 60d / bpm;
            arrowNum++;
        }


        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (array[i] == 0)
            {
                hit++; i++;
                snow.transform.localScale *= 1.1f;
            }
            else
            {
                fail++; i++;
            }
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (array[i] == 1)
            {
                hit++; i++;
                snow.transform.localScale *= 1.1f;
            }
            else
            {
                fail++; i++;
            }
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (array[i] == 2)
            {
                hit++; i++;
                snow.transform.localScale *= 1.1f;
            }
            else
            {
                fail++; i++;
            }
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (array[i] == 3)
            {
                hit++; i++;
                snow.transform.localScale *= 1.1f;
            }
            else
            {
                fail++; i++;
            }
        }

        if (i == 8)
        {
            resulthit();
        }
    }

    void resulthit()
    {
        if (hit >= 6)
        {
            Debug.Log("Success");
            Endingtext.text = "미션 성공 ! 엔터를 누르고 종료";
            if (Input.GetKeyDown(KeyCode.Return))
            {
                tearGauge.value -= 0.1f;
                SceneManager.LoadScene("Day1_End");
            }
        }

        else
        {
            Debug.Log("Fail");
            Endingtext.text = "미션 실패 ! 엔터를 누르고 종료";
            if (Input.GetKeyDown(KeyCode.Return))
            {
                tearGauge.value += 0.4f;
                SceneManager.LoadScene("Day1_End");
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Arrow"))
        {
            Destroy(collision.gameObject);
        }
    }
}
