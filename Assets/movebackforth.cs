using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movebackforth : MonoBehaviour
{
    public float starTime;
    public float minX, maxX;
    public float moveSpeed;
    private int sign = -1;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= starTime)
        {
            transform.position += new Vector3(moveSpeed * Time.deltaTime*sign, 0, 0);
        }
    }
}
