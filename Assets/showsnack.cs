using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showsnack : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount == 1)
        {
            gameObject.SetActive(true);
        }
    }
}
