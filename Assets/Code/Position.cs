using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Position : MonoBehaviour
{
    public Transform Pet;
    public GameObject Panel;
    private bool done;
    // Start is called before the first frame update
    void Start()
    {
        done = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Panel.activeSelf == true && !done)
        {
            PlayerPrefs.SetFloat("Pet_x", Pet.position.x);
            PlayerPrefs.SetFloat("Pet_y", Pet.position.y);
            PlayerPrefs.SetFloat("Pet_z", Pet.position.z);
            done = true;
        }
    }
}
