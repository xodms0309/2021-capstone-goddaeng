using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Train2animControl : MonoBehaviour
{
    public Animator anim;
    public Transform Pet;
    public Transform Pad;
    public GameObject Target;
    private bool com;
    private bool isMove;
    private Vector3 destination;
    public GameObject txt;

    void Start()
    {
        com = false;
        anim.SetBool("Start", false);
        anim.SetBool("Idle", true);
        txt.SetActive(false);
    }

    void Update()
    {
        SetDestination(Pad.position);
        Move();
    }

    private void SetDestination(Vector3 dest)
    {
        if (com && anim.GetCurrentAnimatorStateInfo(0).IsName("CorgiWalk 0"))
        {
            destination = Vector3.zero - 6 * Vector3.back;
            txt.SetActive(true);
        }
        else
        {
            destination = dest;
        }
        isMove = true;
    }

    private void Move()
    {
        if (isMove)
        {
            if (Vector3.Distance(destination, transform.position) <= 0.1f)
            {
                isMove = false;
                com = true;
                anim.SetBool("Start", true);
                return;
            }
            var dir = destination - transform.position;
            transform.position += dir.normalized * Time.deltaTime;
        }
    }
}
