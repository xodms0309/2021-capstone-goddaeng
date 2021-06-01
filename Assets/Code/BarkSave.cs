using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarkSave : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Step1()
    {
        PlayerPrefs.SetInt("Train2", 20);
    }
    public void Step2()
    {
        PlayerPrefs.SetInt("Train2", 40);
    }
    public void Step3()
    {
        PlayerPrefs.SetInt("Train2", 60);
    }
    public void Step4()
    {
        PlayerPrefs.SetInt("Train2", 80);
    }
}
