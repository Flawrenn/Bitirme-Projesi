using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_Motion : MonoBehaviour
{
    void Update()
    {
        float hiz = 10;
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(hiz * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(-hiz * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, hiz * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -hiz * Time.deltaTime);
        }
    }
}
