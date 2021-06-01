using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marker : MonoBehaviour
{
    public bool Snack_Marker;
    public GameObject Snack_Button;
    public GameObject Snack;
    public GameObject Panel;

    public void Start()
    {
        Snack_Button.SetActive(false);
    }

    public void OnSnack() //간식 마커가 인식 되었을 때
    {
        Snack_Marker = true;
    }

    public void OffSnack()  //간식 마커가 인식 되지 않았을 때
    {
        Snack_Marker = false;
    }

    public GameObject Pet;  //강아지의 위치
    private Vector3 Destination;  //갈 방향
    public Transform PositionSnack;  //간식의 위치
    public GameObject Target;
    public Transform Pet_Rotation;
 

    private void Update()
    {
        if (Panel.activeSelf == true)
        {
            float Distance = Vector3.Distance(Destination, Pet.transform.position);
            Pet.transform.position += Vector3.Normalize(Destination - Pet.transform.position) * Distance * Time.deltaTime * 0.5f;  //강아지의 위치를 시간당 움직임으로 구현
            float y = PlayerPrefs.GetFloat("Pet_y");
            //Vector3 tar_rot = new Vector3(Target.transform.position.x, Pet.transform.position.y, Target.transform.position.z);
            //Vector3 tar_rot = new Vector3(Destination.x, 0, Destination.z);
            Vector3 tar_rot = new Vector3(Target.transform.position.x, 0, Target.transform.position.z);
            Quaternion targetRot = Quaternion.LookRotation(tar_rot);
            //Pet.transform.rotation = Quaternion.Lerp(Pet.transform.rotation, targetRot, Time.deltaTime * 5);
            Pet_Rotation.rotation = Quaternion.Lerp(Pet_Rotation.rotation, targetRot, Time.deltaTime * 5);

            if (Snack_Marker)
            {
                //Destination = PositionSnack.position - Vector3.back;
                Destination = new Vector3(PositionSnack.position.x, y, PositionSnack.position.z);
                //Destination = PositionSnack.position;
                //간식이 인식됐다면 목적지는 간식의 방향

            }
            else 
            {
                float x = PlayerPrefs.GetFloat("Pet_x");
                //float y = PlayerPrefs.GetFloat("Pet_y");
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
        if (Snack_Marker != true)
        {
            Snack_Button.SetActive(false);
        }
    }
}
