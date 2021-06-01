using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newPoop : MonoBehaviour
{
    public Animator anim;
    public GameObject Pet;
    public Transform Pad;
    private bool isMove;
    private Vector3 destination;
    public GameObject Panel;
    public GameObject nextPanel;
    bool state;
    bool SnackButtonPushed;
    public GameObject SnackButton;
    public GameObject Snack;

    void Start()
    {
        isMove = false;
        anim.SetBool("poop", false);
        SnackButton.SetActive(false);
        state = false;
        SnackButtonPushed= true;
    }
    void Update()
    {
        if (Panel.activeSelf == true)
        {
            //if (!state)
            //{
            //    Pet.transform.Rotate(new Vector3(0, 1, 0), 180.0f);
            //}

            SetDestination(Pad.position);
            Move();
            ShowSnackButton();
            state = true;

        }

    }
    private void SetDestination(Vector3 dest)
    {
        destination = dest;
        isMove = true;
    }
    private void Move()
    {
        if (isMove)
        {
            Pet.transform.position = Vector3.MoveTowards(Pet.transform.position, Pad.position, 0.01f);
            if (Pad.position == Pet.transform.position)
            {
                isMove = false;
                anim.SetBool("poop", true);
                //anim.Play("CorgiPoop");

                //anim.SetBool("time", true);
                //return;
            }

            //var dir = destination - Pet.transform.position;
            //Pet.transform.position += dir.normalized * Time.deltaTime;
        }

    }
    private void ShowSnackButton()
    {
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("CorgiWalk1")&&SnackButtonPushed)
        {
            Snack.SetActive(true);
            SnackButton.SetActive(true);
            SnackButtonPushed = false;
        }

    }
}
