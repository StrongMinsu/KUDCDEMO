using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class default_page : MonoBehaviour
{
    private void Start()
    {
        GameObject.Find("BrowserGUI").SetActive(false);
    }
}
