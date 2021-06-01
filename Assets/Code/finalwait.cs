using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalwait : MonoBehaviour
{
    public GameObject Panel2;
    public GameObject corgi;
    private Animation anim;
    public GameObject pad;


    void Start()
    {
        anim = gameObject.GetComponent<Animation>();
    }


    void Update()
    {
        if (Panel2 == true)
        {
            anim.Play("CorgiWalk");
            transform.position = Vector3.MoveTowards(corgi.transform.position, pad.transform.position, 0.07f);
            anim.Play("CorgiWait");

        }
    }
}
