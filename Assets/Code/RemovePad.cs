using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemovePad : MonoBehaviour
{
    public GameObject pad1;
    public GameObject pad2;
    public GameObject but1;
    public GameObject but2;
    public GameObject text;
    public Animator anim;
    private bool end;
    // Start is called before the first frame update
    void Start()
    {
        but1.SetActive(false);
        but2.SetActive(false);
        anim.SetBool("End", false);
        end = false;
    }

    // Update is called once per frame
    void Update()
    {
        checkStatus();
    }

    public void checkStatus()
    {
        if (text.activeSelf == true && pad1.activeSelf == true && pad2.activeSelf == true)
        {
            but1.SetActive(true);
            but2.SetActive(true);
        }
        if (pad1.activeSelf == false && pad2.activeSelf == false && !anim.GetCurrentAnimatorStateInfo(0).IsName("CorgiWalk"))
        {
            anim.SetBool("Start", false);
            anim.SetBool("End", true);
            anim.SetBool("Idle", false);
        }
    }

    public void removePad1()
    {
        but1.SetActive(false);
        pad1.SetActive(false);
    }

    public void removePad2()
    {
        but2.SetActive(false);
        pad2.SetActive(false);
        end = true;
    }
}
