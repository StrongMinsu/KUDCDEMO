using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using ZenFulcrum.EmbeddedBrowser;

public class SmartContract : MonoBehaviour
{
    public void Open_ContractPage()
    {
        Browser.browser = Browser.homepageType.pay;
        SceneManager.LoadScene("ContractPage");
    }
}
