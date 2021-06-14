using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ZenFulcrum.EmbeddedBrowser;

public class etc_page_btn_mng : MonoBehaviour
{
    public void Dona()
    {
        GameObject.Find("WebView").transform.GetChild(12).gameObject.SetActive(true);
        ZenFulcrum.EmbeddedBrowser.Browser.browser = Browser.homepageType.dona;
        GameObject.Find("WebView").transform.GetChild(8).gameObject.SetActive(true);
        GameObject.Find("WebView").transform.GetChild(13).gameObject.SetActive(true);
    }

    public void Medic()
    {
        GameObject.Find("WebView").transform.GetChild(12).gameObject.SetActive(true);
        ZenFulcrum.EmbeddedBrowser.Browser.browser = Browser.homepageType.medic;
        GameObject.Find("WebView").transform.GetChild(8).gameObject.SetActive(true);
        GameObject.Find("WebView").transform.GetChild(13).gameObject.SetActive(true);

    }

    public void Notice()
    {
        GameObject.Find("WebView").transform.GetChild(12).gameObject.SetActive(true);
        ZenFulcrum.EmbeddedBrowser.Browser.browser = Browser.homepageType.notice;
        GameObject.Find("WebView").transform.GetChild(8).gameObject.SetActive(true);
        GameObject.Find("WebView").transform.GetChild(13).gameObject.SetActive(true);
    }

    public void Tuition()
    {
        GameObject.Find("WebView").transform.GetChild(12).gameObject.SetActive(true);
        ZenFulcrum.EmbeddedBrowser.Browser.browser = Browser.homepageType.tuition;
        GameObject.Find("WebView").transform.GetChild(8).gameObject.SetActive(true);
        GameObject.Find("WebView").transform.GetChild(13).gameObject.SetActive(true);
    }


}
