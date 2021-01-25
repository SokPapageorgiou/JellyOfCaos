using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CameraListner 
{
    public class CameraOutput 
    {
        public Transform GetTransform()
        {
            Transform _mainCameraTransform = FindMainCamera().transform;

            return _mainCameraTransform;
        }

        public float GetZRotation() 
        {
            float _zRotation = FindMainCamera().transform.eulerAngles.z;

            return _zRotation;
        }

        private GameObject FindMainCamera()
        {
            return GameObject.FindGameObjectWithTag("MainCamera");
        }
    }
}
