using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class corgiwait : MonoBehaviour
{
    public GameObject snack;
    public GameObject target;
    public GameObject Panel;
    public Animator anim;
    public Transform Pet;
    bool state;

    // Start is called before the first frame update
    void Start()
    {
        anim.SetBool("waiton", false);
        state = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Panel.activeSelf == true)
        {
            if (PlayerPrefs.GetInt("done") == 1)
            {
                //Debug.Log("true");
                anim.SetBool("snackshow", false);
                //if (!state)
                //{
                //    Pet.Rotate(new Vector3(0, 1, 0), 180.0f);
                //}
                //state = true;
                //Pet.position = Vector3.MoveTowards(Pet.position, target.transform.position, 0.05f);
                //if (Pet.position == target.transform.position)
                //{
                    anim.SetBool("waiton", true);
                //}

            }
        }
        
    }
}
