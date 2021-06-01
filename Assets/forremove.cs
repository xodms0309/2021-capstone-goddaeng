using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forremove : MonoBehaviour
{
    public GameObject Panel1;
    public GameObject Panel2;
    public GameObject doggy;
    private Animation anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animation>();

        Panel1.SetActive(true);
        Panel2.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (anim.Play("CorgiWait"))
        {
            Panel1.SetActive(false);
            Panel2.SetActive(true);
        }
    }
}
