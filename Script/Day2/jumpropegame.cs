using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class jumpropegame : MonoBehaviour
{
    public Slider tearGauge;
    int turnspeed=300;
    int count=0;
    int printcnt = 0;
    public Text Scripttxt;
    public Text ending;
    // Start is called before the first frame update
    void Start()
    {
        tearGauge = Slider.FindObjectOfType<Slider>();
        Scripttxt.text = "";
        ending.text = "";
    }
    private void OnTriggerEnter(Collider other)
    {
        turnspeed = 0;
        ending.text = "����! �������� 3 �ö󰬽��ϴ�.\n ���� ������ �̼� ��ġ��";
        tearGauge.value += 0.3f;
    }

    
    // Update is called once per frame
    void Update()
    {
            
            //turnspeed = Random.Range(50, 500);
        transform.Rotate(Vector3.up, turnspeed * Time.deltaTime*(count)/4);
        if (Input.GetMouseButtonDown(0))
        {
            count++;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            count++;
            printcnt = count - 1;
            Scripttxt.text = "Count: "+ printcnt;
        }
       
        if (printcnt == 10)
        {
            turnspeed = 0;
            ending.text = "����! �������� 1 ���������ϴ�.\n ���� ������ �̼� ��ġ��";
            if (Input.GetKeyDown(KeyCode.Return))
            {
                tearGauge.value -= 0.1f;
                SceneManager.LoadScene("Day2_End");
            }
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("Day2_End");
        }
        //Debug.Log(turnspeed);
    }
}
