using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Progress1 : MonoBehaviour
{
    float maxProgress = 100f;
    public static int pg1;
    public static int pg2;
    public Image pg1Bar;
    public Image pg2Bar;
    // Start is called before the first frame update
    void Start()
    {
        pg1 = 0;
        pg2 = 0;
        pg1 = PlayerPrefs.GetInt("Train1");
        pg2 = PlayerPrefs.GetInt("Train2");
    }

    // Update is called once per frame
    void Update()
    {
        pg1 = PlayerPrefs.GetInt("Train1");
        //pg2 = PlayerPrefs.GetInt("Train2");
        pg2 = 20;
        pg1Bar.fillAmount = pg1 / maxProgress;
        pg2Bar.fillAmount = pg2 / maxProgress;
        //Debug.Log(pg1);
    }
}
