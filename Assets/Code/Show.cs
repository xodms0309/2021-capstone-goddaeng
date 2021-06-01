using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Show : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Panel;
    public Animator animator;
    void ShowPanel()
    {
        Debug.Log(animator.GetCurrentAnimatorStateInfo(0).nameHash);
        if (animator.GetCurrentAnimatorStateInfo(0).nameHash == Animator.StringToHash("Base Layer.CorgiIdleToSit"))
        {
            Panel.gameObject.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
