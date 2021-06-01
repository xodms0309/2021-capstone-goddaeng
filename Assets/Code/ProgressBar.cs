using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode()]
public class ProgressBar : MonoBehaviour
{
    //public int max;
    //public int current;
    //public Image mask;
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
        if (PlayerPrefs.HasKey("Train1"))
        {
            pg1 = PlayerPrefs.GetInt("Train1");
        }
        if (PlayerPrefs.HasKey("Train2"))
        {
            pg2 = PlayerPrefs.GetInt("Train2");
        }
    }

    // Update is called once per frame
    void Update()
    {
        getCurrentFill();
    }
    void getCurrentFill()
    {
        //float fillAmount = (float)current /(float) max;
        //mask.fillAmount = fillAmount;
        if (PlayerPrefs.HasKey("Train1"))
        {
            pg1 = PlayerPrefs.GetInt("Train1");
        }
        else
        {
            pg1 = 0;
        }
        if (PlayerPrefs.HasKey("Train2"))
        {
            pg2 = PlayerPrefs.GetInt("Train2");
        }
        else
        {
            pg2 = 0;
        }
        pg1Bar.fillAmount = (float)pg1 / maxProgress;
        pg2Bar.fillAmount = (float)pg2 / maxProgress;
    }
}
