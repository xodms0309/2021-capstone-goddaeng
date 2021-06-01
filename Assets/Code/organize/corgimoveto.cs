using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class corgimoveto : MonoBehaviour
{
    public Transform Pet;
    public Animator anim;
    public GameObject panel;

    public GameObject target1;
    public GameObject target2;
    public GameObject target3;
    bool state;
    public GameObject Controller;

    public GameObject panel2;
    void Start()
    {
        state = false;
        PlayerPrefs.SetInt("done", 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (panel.activeSelf == true)
        {
            if (!state)
            {
                transform.Rotate(new Vector3(0, 1, 0), 180.0f);
            }
            if (target1.activeSelf == true)
            {
                Pet.position = Vector3.MoveTowards(Pet.position, target1.transform.position, 0.05f);
                if (Pet.position == target1.transform.position)
                {
                    anim.SetBool("snackshow", true);
                    target1.SetActive(false);
                }
            }
            else if (target2.activeSelf == true)
            {
                anim.SetBool("snackshow", false);
                Pet.position = Vector3.MoveTowards(Pet.position, target2.transform.position, 0.05f);
                if (Pet.position == target2.transform.position)
                {
                    anim.SetBool("snackshow", true);
                    target2.SetActive(false);
                }
            }
            else if (target3.activeSelf == true)
            {
                anim.SetBool("snackshow", false);
                Pet.position = Vector3.MoveTowards(Pet.position, target3.transform.position, 0.05f);
                if (Pet.position == target3.transform.position)
                {
                    anim.SetBool("snackshow", true);
                    target3.SetActive(false);
                    PlayerPrefs.SetInt("done", 1);
                }
            }
            state = true;

            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CorgiIdleLong 0"))
            {
                panel.SetActive(false);
                panel2.SetActive(true);
                Controller.SetActive(false);
            }
        }


    }
    
}
