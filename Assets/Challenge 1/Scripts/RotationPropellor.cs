using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationPropellor : MonoBehaviour
{
    public float rotationSpeed = 10.0f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, rotationSpeed);
    }
}
