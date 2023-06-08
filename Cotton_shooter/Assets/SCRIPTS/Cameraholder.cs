using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameraholder : MonoBehaviour
{
    public Transform camera_position;

    // Update is called once per frame
    void Update()
    {
        transform.position = camera_position.position;
    }
}
