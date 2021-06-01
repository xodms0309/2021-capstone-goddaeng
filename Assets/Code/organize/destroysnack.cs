using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroysnack : MonoBehaviour
{
    private float destroyTime=10f;
    private float tickTime;
    public GameObject snack1;
    public GameObject snack2;
    public GameObject snack3;
    public GameObject corgi;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tickTime += Time.deltaTime;
        if (tickTime >= destroyTime)
        {
            snack1.SetActive(false);


        }
        if (snack2.activeSelf == true)
        {
            transform.position = Vector3.MoveTowards(corgi.transform.position, snack2.transform.position, 0.001f);
            if (tickTime >= destroyTime)
            {
                snack2.SetActive(false);
            }
        }
        if (snack3.activeSelf == true)
        {
            transform.position = Vector3.MoveTowards(corgi.transform.position, snack3.transform.position, 0.001f);
            if (tickTime >= destroyTime)
            {
                snack3.SetActive(false);
            }
        }
    }
}
