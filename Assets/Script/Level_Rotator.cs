using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_Rotator : MonoBehaviour
{
    public float rotationSpeed = 60f;

    void Update()
    {
        transform.Rotate(0f, Time.deltaTime * rotationSpeed, 0f);
    }
}
