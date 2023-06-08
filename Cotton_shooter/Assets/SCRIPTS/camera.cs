using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public float sensitivity_X;
    public float sensitivity_Y;

    public Transform orientation;

    float X_rotation;
    float Y_rotation;

    private void Start ()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update ()
    {
        float Mouse_x = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensitivity_X;
        float Mouse_y = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensitivity_Y;

        Y_rotation += Mouse_x;
        X_rotation -= Mouse_y;
        X_rotation = Mathf.Clamp(X_rotation, -90f, 90f);

        transform.rotation = Quaternion.Euler(X_rotation, Y_rotation, 0);
        orientation.rotation = Quaternion.Euler(0, Y_rotation, 0);

    }
}
