using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Arrange : MonoBehaviour
{
    public Slider[] tearGauge;
    public GameObject bed;
    public GameObject[] arrange_object;
    public Text check;
    public Text ending;
    int speed = 15;
    public int objectNumber;
    Vector3 trans_V;
    public GameObject list;

    [SerializeField]
    public Slider timer;

    // Start is called before the first frame update
    void Start()
    {
        list = GameObject.FindGameObjectWithTag("list");
        tearGauge = Slider.FindObjectsOfType<Slider>();
        bed = GameObject.FindGameObjectWithTag("bed");
        for (int i = 0; i < 8; i++)
        {
            arrange_object = GameObject.FindGameObjectsWithTag("object");
        }
        this.transform.position = arrange_object[0].transform.position;
        objectNumber = 0;
                
    }

    void Update()
    {
        check.text = "옮긴 짐 개수 : " + objectNumber.ToString();
        if (timer.value == 0)
        {
            ending.text = "Fail ! 엔터를 눌러 종료하시오";
            if (Input.GetKey(KeyCode.Return))
            {
                tearGauge[0].value += 0.3f;
                list.GetComponent<Text>().text = "Mission list\n- 우유 선택 게임\n- 과자 찾기 게임\n- 눈굴리기 게임";
                SceneManager.LoadScene("Day1_Bedroom2");
            }
        }
        if (objectNumber >= 8)
        {
            ending.text = "Success ! 엔터를 눌러 종료하시오";
            if (Input.GetKey(KeyCode.Return))
            {
                tearGauge[0].value -= 0.1f;
                list.GetComponent<Text>().text = "Mission list\n- 우유 선택 게임\n- 과자 찾기 게임\n- 눈굴리기 게임";
                SceneManager.LoadScene("Day1_Bedroom2");
            }
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.transform.Translate(new Vector3(0, 0, 1) * speed * Time.deltaTime, Space.World);
            arrange_object[objectNumber].transform.Translate(new Vector3(0,0,1) *speed* Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.transform.Translate(new Vector3(0, 0, -1) * speed * Time.deltaTime, Space.World);
            arrange_object[objectNumber].transform.Translate(new Vector3(0, 0, -1) * speed * Time.deltaTime, Space.World);

        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.transform.Translate(new Vector3(0, 1, 0) * speed * Time.deltaTime, Space.World);
            arrange_object[objectNumber].transform.Translate(new Vector3(0, 1, 0) * speed * Time.deltaTime, Space.World);

        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.transform.Translate(new Vector3(0, -1, 0) * speed * Time.deltaTime, Space.World);
            arrange_object[objectNumber].transform.Translate(new Vector3(0, -1, 0) * speed * Time.deltaTime, Space.World);

        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.transform.Translate(new Vector3(-1, 0, 0) * speed * Time.deltaTime, Space.World);
            arrange_object[objectNumber].transform.Translate(new Vector3(-1, 0,0) * speed * Time.deltaTime, Space.World);

        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.transform.Translate(new Vector3(1, 0, 0) * speed * Time.deltaTime, Space.World);
            arrange_object[objectNumber].transform.Translate(new Vector3(1, 0, 0) * speed * Time.deltaTime, Space.World);

        }

        this.transform.position = arrange_object[objectNumber].transform.position;
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("bed"))
        {
            if (objectNumber != 8)
            {
                objectNumber++;
                this.transform.position = arrange_object[objectNumber].transform.position;
            }
                                    
            Debug.Log("Success");
        }
    }
}
