using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newmoveto : MonoBehaviour
{
    public GameObject Pet;
    public Animator anim;
    public GameObject panel;
    public GameObject panel2;
    public GameObject target1;
    public GameObject target2;
    public GameObject target3;
    bool state;
    private Vector3 Destination;  //갈 방향
    public Transform Pet_Rotation;
    void Start()
    {
        state = false;
        PlayerPrefs.SetInt("done", 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (panel.activeSelf == true)
        {
            anim.SetBool("hello", false);
            if (target1.activeSelf == true)
            {
                float Distance = Vector3.Distance(target1.transform.position, Pet.transform.position);
                Pet.transform.position += Vector3.Normalize(Destination - Pet.transform.position) * Distance * Time.deltaTime * 0.5f;  //강아지의 위치를 시간당 움직임으로 구현
                Vector3 tar_rot = new Vector3(target1.transform.position.x, target1.transform.position.y, target1.transform.position.z);
                Quaternion targetRot = Quaternion.LookRotation(tar_rot);
                Pet_Rotation.rotation = Quaternion.Slerp(Pet_Rotation.rotation, targetRot, Time.deltaTime * 5);
                Destination = new Vector3(target1.transform.position.x, target1.transform.position.y, target1.transform.position.z);
                if (Distance<0.2f)
                {
                    Debug.Log("ddd");
                    anim.SetBool("snackshow", true);
                    target1.SetActive(false);
                }
            }
            else if (target2.activeSelf == true)
            {
                anim.SetBool("snackshow", false);
                if (anim.GetCurrentAnimatorStateInfo(0).IsName("CorgiWalk"))
                {
                    float Distance = Vector3.Distance(target2.transform.position, Pet.transform.position);
                    Pet.transform.position += Vector3.Normalize(Destination - Pet.transform.position) * Distance * Time.deltaTime * 0.5f;  //강아지의 위치를 시간당 움직임으로 구현
                    Vector3 tar_rot = new Vector3(target2.transform.position.x, target2.transform.position.y, target2.transform.position.z);
                    Quaternion targetRot = Quaternion.LookRotation(tar_rot);
                    //Pet_Rotation.rotation = Quaternion.Lerp(Pet_Rotation.rotation, targetRot, Time.deltaTime * 5);
                    Destination = new Vector3(target2.transform.position.x, target2.transform.position.y, target2.transform.position.z);

                    if (Distance < 0.1f)
                    {
                        anim.SetBool("snackshow", true);
                        target2.SetActive(false);
                    }
                }
            }
            else if (target3.activeSelf == true)
            {
                anim.SetBool("snackshow", false);
                if (anim.GetCurrentAnimatorStateInfo(0).IsName("CorgiWalk"))
                {
                    float Distance = Vector3.Distance(target3.transform.position, Pet.transform.position);
                    Pet.transform.position += Vector3.Normalize(Destination - Pet.transform.position) * Distance * Time.deltaTime * 0.5f;  //강아지의 위치를 시간당 움직임으로 구현
                    Vector3 tar_rot = new Vector3(target3.transform.position.x, target3.transform.position.y, target3.transform.position.z);
                    Quaternion targetRot = Quaternion.LookRotation(tar_rot);
                    //Pet_Rotation.rotation = Quaternion.Lerp(Pet_Rotation.rotation, targetRot, Time.deltaTime * 5);
                    Destination = new Vector3(target3.transform.position.x, target3.transform.position.y, target3.transform.position.z);

                    if (Distance < 0.1f)
                    {
                        anim.SetBool("snackshow", true);
                        target3.SetActive(false);
                        PlayerPrefs.SetInt("done", 1);
                    }
                }
            }
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("CorgiIdleLong 0"))
            {
                panel.SetActive(false);
                panel2.SetActive(true);

            }
        }

    }
}
