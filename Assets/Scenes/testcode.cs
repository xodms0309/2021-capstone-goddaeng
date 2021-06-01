using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testcode : MonoBehaviour
{
    public GameObject Pet;  //강아지의 위치
    private Vector3 Destination;  //갈 방향
    public Transform PositionSnack;  //간식의 위치
    public GameObject Target;
    public Transform Pet_Position;


    private void Update()
    {

            float Distance = Vector3.Distance(Destination, Pet.transform.position);
            Pet.transform.position += Vector3.Normalize(Destination - Pet.transform.position) * Distance * Time.deltaTime * 0.5f;  //강아지의 위치를 시간당 움직임으로 구현
            float y = PlayerPrefs.GetFloat("Pet_y");
            //Vector3 tar_rot = new Vector3(Pet.transform.position.x, Pet.transform.position.y, Target.transform.position.z);
            //Vector3 tar_rot = new Vector3(Pet.transform.position.x, Pet.transform.position.y, Destination.z);
            //Vector3 tar_rot = new Vector3(Destination.x, 0, Destination.z);
            Vector3 tar_rot = new Vector3(Target.transform.position.x, 0, Target.transform.position.z);
            Quaternion targetRot = Quaternion.LookRotation(tar_rot);
            //Quaternion targetRot = Quaternion.LookRotation(Target.transform.position);
            //Pet_Position.rotation = Quaternion.Lerp(Pet_Position.rotation, targetRot, Time.deltaTime * 4);


            Destination = new Vector3(PositionSnack.position.x, y, PositionSnack.position.z);
    }
}
