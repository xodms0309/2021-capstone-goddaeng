using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class STTPanelControl : MonoBehaviour
{
    public GameObject Panel0;
    public GameObject Panel1;
    public GameObject Panel2;
    public GameObject Panel3;
    public GameObject Panel4;
    public GameObject STTPanel;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Panel0.activeSelf) STTPanel.SetActive(true);
        if (Panel1.activeSelf) STTPanel.SetActive(false);
        if (Panel2.activeSelf) STTPanel.SetActive(false);
        if (Panel3.activeSelf) STTPanel.SetActive(true);
        if (Panel4.activeSelf) STTPanel.SetActive(false);
    }
}
