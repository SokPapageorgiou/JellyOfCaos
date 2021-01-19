using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CameraListner 
{
    public class CameraOutput 
    {
        public Transform GetTransform() 
        {
            Transform _mainCameraTransform = GameObject.FindGameObjectWithTag("MainCamera").transform;

            return _mainCameraTransform;
        }

        public float GetZRotation() 
        {
            float _zRotation = GameObject.FindGameObjectWithTag("MainCamera").transform.eulerAngles.z;

            return _zRotation;
        }
    }

}
