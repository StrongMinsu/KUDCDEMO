using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Mng : MonoBehaviour
{
    public void Goto_App()
    {
        SceneManager.LoadScene("app");
    }
    public void Goto_Etc()
    {
        SceneManager.LoadScene("etc");
    }
    public void Goto_Metaverse()
    {
        SceneManager.LoadScene("metaverse");
    }
}
