using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marker_2 : MonoBehaviour
{
    public bool Snack_Marker;
    public GameObject Snack_Button;
    public GameObject Snack;
    public GameObject Panel;
    public Animator anim;

    public void Start()
    {
        Screen.SetResolution(1080,1920, true);
        Snack_Button.SetActive(false);
    }

    public void OnSnack() //간식 마커가 인식 되었을 때
    {
        Snack_Marker = true;
        anim.SetBool("idle", true);
    }

    public void OffSnack()  //간식 마커가 인식 되지 않았을 때
    {
        Snack_Marker = false;
        anim.SetBool("idle", false);
    }

    public Transform Pet;  //강아지의 위치
    private Vector3 Destination;  //갈 방향
    public Transform PositionSnack;  //간식의 위치
    public GameObject Target;


    private void Update()
    {
        if (Panel.activeSelf == true)
        {
            //float Distance = Vector3.Distance(Destination, Pet.transform.position);
            //Pet.transform.position += Vector3.Normalize(Destination - Pet.transform.position) * Distance * Time.deltaTime * 0.5f;  //강아지의 위치를 시간당 움직임으로 구현
            float Distance = Vector3.Distance(Destination, Pet.position);
            Pet.position += Vector3.Normalize(Destination - Pet.position) * Distance * Time.deltaTime *1.2f;
            //Quaternion targetRot = Quaternion.LookRotation(Target.transform.position);
            //Pet.transform.rotation = Quaternion.Lerp(Pet.transform.rotation, targetRot, Time.deltaTime * 5);

            if (Snack_Marker)
            {
                //Destination = PositionSnack.position - Vector3.back;
                float y = PlayerPrefs.GetFloat("Pet_y");
                Destination = new Vector3(PositionSnack.position.x, y, PositionSnack.position.z);
                //Destination = PositionSnack.position;
                //간식이 인식됐다면 목적지는 간식의 방향, 간식보다 살짝 뒤에 위치시키기 위해 1 back 시켜줌

            }
            else
            {
                //int x = Random.Range(0, 8);
                //int z = Random.Range(-15, -5);
                //Vector3 targetPosition = new Vector3(0, 0, z);
                float x = PlayerPrefs.GetFloat("Pet_x");
                float y = PlayerPrefs.GetFloat("Pet_y");
                float z = PlayerPrefs.GetFloat("Pet_z");
                Vector3 vector;
                vector = new Vector3(x, y, z);
                Destination = vector;
                //Snack_Button.SetActive(false);
            }
        }
    }

    public void ButtonOn()
    {
        if (Snack_Marker)
        {
            Snack.SetActive(true);
            Snack_Button.SetActive(true);
        }
    }

    public void ButtonOff()
    {
        if (Panel.activeSelf == true)
        {
            if (Snack_Marker != true)
            {
                Snack_Button.SetActive(false);
            }
        }
    }
}
