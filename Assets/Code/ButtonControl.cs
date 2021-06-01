using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControl : MonoBehaviour
{
    public bool SnackButtonPushed;
    public bool PraiseButtonPushed;
    public GameObject SnackButton;
    public GameObject PraiseButton;

    //Start is called before the first frame update
    void Start()
    {
        SnackButtonPushed = false;
        PraiseButtonPushed = false;
        PraiseButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }


    void SnackPush()
    {
        SnackButtonPushed = true;
        if (SnackButtonPushed)
        {
            SnackButton.SetActive(false);
            PraiseButton.SetActive(true);
        }
    }

    void PraisePush()
    {
        PraiseButtonPushed = true;
        if (PraiseButtonPushed)
        {
            PraiseButton.SetActive(false);
        }
    }
}
