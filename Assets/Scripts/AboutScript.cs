using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AboutScript : MonoBehaviour
{
    [SerializeField]
    GameObject panel;

    [SerializeField]
    TMP_Text creditText;

    public void ShowPanel()
    {
        panel.SetActive(true);
        Debug.Log(creditText.text);
    }

    public void HidePanel()
    {
        panel.SetActive(false);
    }

}
