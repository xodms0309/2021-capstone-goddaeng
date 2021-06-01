using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenSetCod : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        Screen.SetResolution(1080, 1920, true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
