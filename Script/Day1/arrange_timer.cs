using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class arrange_timer : MonoBehaviour
{
    [SerializeField]
    public Slider timer;

    private float maxTime = 100f;
    private float curTime = 100f;
    // Start is called before the first frame update
    void Start()
    {
        timer.value = (float)curTime / (float)maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        curTime -= 5 * Time.deltaTime;
        timeGauge();
    }

    void timeGauge()
    {
        timer.value = (float)curTime / (float)maxTime;
    }
}
