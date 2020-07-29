﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float mouseSensitivity = 125f;

    public Transform playerBody;

    float xRotation = 0f;

	// Use this for initialization
	void Start ()
    {
        Cursor.lockState = CursorLockMode.Locked;
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Getting mouse inputs
        float xAxis = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float yAxis = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        //Preventing from view leaping
        xRotation -= yAxis;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        //Allowing player to look around vertical
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        //Allowing player to look around horizontal
        playerBody.Rotate(Vector3.up * xAxis);
    }
}
