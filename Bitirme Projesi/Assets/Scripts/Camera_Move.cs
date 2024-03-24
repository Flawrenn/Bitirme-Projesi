using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Move : MonoBehaviour
{
    private float xRotation = 0.0f;
    public float mouseSensivity = 100f;

    public GameObject AlienDestroyer;
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * mouseSensivity;
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * mouseSensivity;

        xRotation += mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        AlienDestroyer.transform.Rotate(Vector3.up * mouseX);
    }
}
