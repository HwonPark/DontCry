using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teargauge : MonoBehaviour
{
    [SerializeField]
    public GameObject tearGauge;
    [SerializeField]
    public GameObject day;
    [SerializeField]
    public GameObject list;


    private void Awake()
    {
        DontDestroyOnLoad(tearGauge);
        DontDestroyOnLoad(day);
        DontDestroyOnLoad(list);
    }
}
