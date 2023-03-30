using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;




public class Day3_Click : MonoBehaviour
{
    public Slider tearGauge;
    public GameObject list;

    void Start()
    {
        tearGauge = Slider.FindObjectOfType<Slider>();
        list = GameObject.FindGameObjectWithTag("list");
        
    }
    // Start is called before the first frame update
    public void EnterToPlayorNot()
    {
        SceneManager.LoadScene("PlayOrNot");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            tearGauge.value += 0.1f;
            list.GetComponent<Text>().text = "Mission list\n- 수학 문제 풀기\n- 눈사람 만들기";
            SceneManager.LoadScene("Day3_LivingroomKitchen2");
        }
    }
}
