using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeLabel : MonoBehaviour
{

    [SerializeField] Text time;

    
    void Update()
    {
        time.text = DateTime.Now.ToString("hh : mm");
    }
}
