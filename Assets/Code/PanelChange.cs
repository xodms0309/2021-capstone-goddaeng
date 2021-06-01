using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelChange : MonoBehaviour
{
    public GameObject thirdPanel;
    public GameObject fourthPanel;
    public GameObject fifthPanel;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("CorgiWalk 0 0") && anim.GetBool("Fin") == true)
        {
            thirdPanel.SetActive(false);
            fourthPanel.SetActive(true);
        }
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("CorgiIdle"))
        {
            fourthPanel.SetActive(false);
            fifthPanel.SetActive(true);
        }
    }
}
