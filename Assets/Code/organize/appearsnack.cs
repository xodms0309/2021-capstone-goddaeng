using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class appearsnack : MonoBehaviour
{
    public Animator anim;
    public GameObject snack0;
    public GameObject snack1;
    public GameObject snack2;
    public GameObject panel;
    public GameObject panel2;

    // Start is called before the first frame update
    void Start()
    {
        snack0.SetActive(false);
        snack1.SetActive(false);
        snack2.SetActive(false);
        PlayerPrefs.SetInt("Snack", 0);
        //PlayerPrefs.SetInt("Snack 1", 0);
        //PlayerPrefs.SetInt("Snack 2", 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (panel.activeSelf)
        {

            if (Input.GetMouseButtonDown(0)&&PlayerPrefs.GetInt("Snack") == 0)
            {
                snack0.SetActive(true);
                PlayerPrefs.SetInt("Snack", 1);

            }
            else if(Input.GetMouseButtonDown(0) && PlayerPrefs.GetInt("Snack") == 1)
            {
                snack1.SetActive(true);
                PlayerPrefs.SetInt("Snack", 2);
            }
            else if (Input.GetMouseButtonDown(0) && PlayerPrefs.GetInt("Snack") == 2)
            {
                snack2.SetActive(true);
                PlayerPrefs.SetInt("Snack", 3);
            }


        }
    }
}
