using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyTest : MonoBehaviour {

    [SerializeField]
    WheelCollider[] colliders;

    void Update()
    {
        foreach (var it in colliders)
        {
            it.motorTorque = -10000f;
        }
    }
}
