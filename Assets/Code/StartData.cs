using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartData : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.HasKey("Train1") && PlayerPrefs.HasKey("Train2"))
        {
            ;
        }
        else if(PlayerPrefs.HasKey("Train1") && !PlayerPrefs.HasKey("Train2"))
        {
            PlayerPrefs.SetInt("Train2", 0);
        }
        else if(!PlayerPrefs.HasKey("Train1") && PlayerPrefs.HasKey("Train2"))
        {
            PlayerPrefs.SetInt("Train1", 0);
        }
        else if (!PlayerPrefs.HasKey("Train1") && !PlayerPrefs.HasKey("Train2"))
        {
            PlayerPrefs.SetInt("Train1", 0);
            PlayerPrefs.SetInt("Train2", 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
