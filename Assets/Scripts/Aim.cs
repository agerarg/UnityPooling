using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    public float mouseSensitivityX = 1f;
    public float mouseSensitivityY = 1f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouse = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        transform.position = new Vector3(mouse.x * mouseSensitivityX, mouse.y * mouseSensitivityY, transform.position.z);
    }
}
