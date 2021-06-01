using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveto : MonoBehaviour
{
    public bool Snack_marker;
    public GameObject Snack_button;
    public Transform Pet;
    private Vector3 Dest;
    public Transform PosiSnack;
    public float MoveSpeed; //속도
    private Vector3 lookdir; //방향

    // Start is called before the first frame update
    void Start()
    {
        Snack_button.SetActive(false);
    }
    public void Onsnack()
    {
        Snack_marker = true;
    }

    public void Offsnack()
    {
        Snack_marker = false;
    }

    // Update is called once per frame
    void Update()
    {
    float Distance = Vector3.Distance(Dest, Pet.position);
        Pet.position += Vector3.Normalize(Dest - Pet.position) * Distance * Time.deltaTime;
        if (Snack_marker)
        {
            Dest = PosiSnack.position - Vector3.back;
        }
        else
        {
            Dest = Vector3.zero - 6 * Vector3.back;
            Snack_button.SetActive(false);
        }
        if (Input.GetKey(KeyCode.LeftArrow) ||
            Input.GetKey(KeyCode.RightArrow) ||
            Input.GetKey(KeyCode.UpArrow) ||
            Input.GetKey(KeyCode.DownArrow))
        {
            float x = Input.GetAxisRaw("Vertical");
            float z = Input.GetAxisRaw("Horizontal");
            lookdir = x * Vector3.forward + z * Vector3.right;
            this.transform.rotation = Quaternion.LookRotation(lookdir);
            this.transform.Translate(Vector3.forward * MoveSpeed * Time.deltaTime);
        }
    }
}
