using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationChange : MonoBehaviour
{
    public Animator anim;
    public bool SnackButtonPushed;
    public bool PraiseButtonPushed;
    public GameObject SnackButton;
    public GameObject PraiseButton;
    public GameObject Snack;
    float timer;
    bool TimeStart;

    public GameObject Panel;
    public GameObject nextPanel;

    public bool isPushed;

    // Start is called before the first frame update
    void Start()
    {
        //SnackButtonPushed = false;
        //PraiseButtonPushed = false;
        PraiseButton.SetActive(false);
        TimeStart = false;
        anim.SetBool("ButtonPush", false);
        anim.SetBool("Praise", false);
        anim.SetBool("Fin", false);
        isPushed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (TimeStart)
        {
            timer += Time.deltaTime;
            anim.SetFloat("Eat", timer);
        }
        //AnimationUpdate();
        if (anim.GetBool("Fin") == true)
        {
            Panel.SetActive(false);
            nextPanel.SetActive(true);
        }
    }

    public void SnackPush()
    {
        timer = 0.0f;
        anim.SetFloat("Eat", 0.0f);
        SnackButtonPushed = true;
        Debug.Log(SnackButtonPushed);
        if (SnackButtonPushed)
        {
            SnackButton.SetActive(false);
            anim.SetBool("ButtonPush", true);
            TimeStart = true;
            Snack.SetActive(false);
            PraiseButton.SetActive(true);
        }
        SnackButtonPushed = false;
        //anim.SetBool("ButtonPush", false);
    }

    public void PraisePush()
    {
        PraiseButtonPushed = true;
        if (PraiseButtonPushed)
        {
            PraiseButton.SetActive(false);
            anim.SetBool("Praise", true);
            anim.SetBool("Fin", true);
            //SetStart();
        }
        PraiseButtonPushed = false;
        isPushed = true;
        //anim.SetBool("Praise", false);
    }

    void AnimationUpdate()
    {
        if (SnackButtonPushed == false)
        {
            anim.SetBool("ButtonPush", false);
        }

        if (!PraiseButtonPushed == false)
        {
            anim.SetBool("Praise", false);
        }
    }

    public void SetStart()
    {
        SnackButtonPushed = false;
        PraiseButtonPushed = false;
        PraiseButton.SetActive(false);
        TimeStart = false;
        anim.SetBool("ButtonPush", false);
        anim.SetBool("Praise", false);
        anim.SetBool("Fin", false);
        timer = 0.0f;
    }
}
