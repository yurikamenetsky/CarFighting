using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GnomeCarArena
{
    public class WheelInfo
    {
        public float torque;
    }
    
    public class Wheel : MonoBehaviour
    {
        [SerializeField]
        Transform mesh;

        [SerializeField]
        WheelCollider collider;

        public WheelInfo info = new WheelInfo();

        bool isStarted = false;

        public void StartRotate()
        {
            //TODO!!!
            info.torque = 500f;
            isStarted = true;
        }

        void Update()
        {
            //if (!isStarted)
                //return;

            collider.motorTorque = -5000f;
            mesh.Rotate(0, -collider.rpm / 60 * 360 * Time.deltaTime, 0);
            Vector3 pos;
            Quaternion rot;
            collider.GetWorldPose(out pos, out rot);
            mesh.position = pos;
        }
    }
}
