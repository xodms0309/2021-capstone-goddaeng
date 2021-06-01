using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movetotarget : MonoBehaviour
{
    
    public GameObject corgi;
    public GameObject snack1;
    public GameObject snack2;
    public GameObject snack3;
    private Animator anim;
    public int cnt;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        snack1.SetActive(false);
        snack2.SetActive(false);
        snack3.SetActive(false);
        cnt = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Ended)
              {
                  snack1.SetActive(true);
                  //transform.position = Vector3.MoveTowards(corgi.transform.position, snack1.transform.position, 0.07f);
                  //if (Vector3.Distance(corgi.transform.position, snack1.transform.position) <= 0.01f) anim.Play("CorgiEat");
                  cnt++;
                  //anim.Play("CorgiWalk");
            }
            else if (cnt==1)
            {
                if (touch.phase == TouchPhase.Ended)
                {
                    snack2.SetActive(true);
                    //transform.position = Vector3.MoveTowards(corgi.transform.position, snack2.transform.position, 0.07f);
                    //if (Vector3.Distance(corgi.transform.position, snack1.transform.position) <= 0.01f)
                    //    anim.Play("CorgiEat");
                    cnt++;
                }
                //anim.Play("CorgiWalk");

            }
            else if (cnt==2)
            {
                if (touch.phase == TouchPhase.Ended)
                {
                    snack3.SetActive(true);
                    //transform.position = Vector3.MoveTowards(corgi.transform.position, snack3.transform.position, 0.07f);
                    //if (Vector3.Distance(corgi.transform.position, snack1.transform.position) <= 0.01f)
                        //anim.Play("CorgiEat");
                }
                //anim.Play("CorgiWait");
            }
        }

    }
}
