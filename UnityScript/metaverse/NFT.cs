using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using System.Linq;
using System;
using UnityEngine.Assertions.Must;
using JetBrains.Annotations;
using TMPro;

public class NFT : MonoBehaviour
{
    public GameObject prefab;
    private DirectoryInfo file_name;
    void Awake()
    {
        string path = "C:\\Users\\president\\Desktop\\KUDCDEMO\\KUDCdemo\\items";
        string[] files = Directory.GetFiles(path, "*.txt");
        if (files.Length > 0)
        {
            Vector3 pos = new Vector3(GameObject.Find("GameObject").transform.position.x, GameObject.Find("GameObject").transform.position.y, GameObject.Find("GameObject").transform.position.z);
            Instantiate(prefab, pos, Quaternion.identity);
        }
    }
}
