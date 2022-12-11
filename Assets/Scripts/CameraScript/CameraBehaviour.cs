using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    [SerializeField]
    private Transform playerBody;
    
    private float sensitivity = 10f;
    float xRotation = 0f;
    
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        
        playerBody.Rotate(Vector3.up * mouseX);
        
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;
        
        xRotation -= mouseY;

    }
}
