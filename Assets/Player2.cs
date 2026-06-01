using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public float speed = 8;

    void Update()
    {
        Vector3 pos = transform.position;
        if (Input.GetKey("l"))
        {
            pos.x += speed * Time.deltaTime;
        }

        if (Input.GetKey("k"))
        {
            pos.x -= speed * Time.deltaTime;
        }
        transform.position = pos;
    }

}