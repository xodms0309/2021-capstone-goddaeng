using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnackButton : MonoBehaviour
{
    public Animator anim;
    public bool SnackButtonPushed;
    public GameObject Button;
    public GameObject Snack;
    public GameObject nextPanel;
    float timer;
    bool TimeStart;

    // Start is called before the first frame update
    void Start()
    {
        TimeStart = false;
        anim.SetBool("SnackButtonPush", false);
        nextPanel.SetActive(false);
        SnackButtonPushed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (TimeStart)
        {
            timer += Time.deltaTime;
            anim.SetFloat("Eat 0", timer);
        }
        
    }

    public void SnackPush()
    {
        timer = 0.0f;
        anim.SetFloat("Eat 0", 0.0f);
        SnackButtonPushed = true;

        if (SnackButtonPushed)
        {
            Button.SetActive(false);
            anim.SetBool("SnackButtonPush", true);
            TimeStart = true;
            Snack.SetActive(false);
            SnackButtonPushed = false;
        }
    }
}
