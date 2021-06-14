using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResolutionMng : MonoBehaviour
{
    //Screen.SetResolution(가로 픽셀, 세로 픽셀, full screen 유무);
    private void Awake()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        Screen.SetResolution(1080, 2400, true);
    }
}