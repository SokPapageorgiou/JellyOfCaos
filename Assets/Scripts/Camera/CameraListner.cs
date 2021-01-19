using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CameraListner 
{
    public class CameraOutput 
    {
        public Transform GetMainCameraTransform() 
        {
            Transform _mainCameraTransform = GameObject.FindGameObjectWithTag("MainCamera").transform;

            return _mainCameraTransform;
        }
    }

}
