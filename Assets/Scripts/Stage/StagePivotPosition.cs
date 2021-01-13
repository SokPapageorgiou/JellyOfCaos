using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CameraListner;

public class StagePivotPosition : MonoBehaviour
{
    private CameraOutput _cameraOutput = new CameraOutput();
    private Transform _currentMainCameraTransform;

    void Update()
    {
        _currentMainCameraTransform = _cameraOutput.GetMainCameraTransform();

        transform.position = new Vector3(_currentMainCameraTransform.position.x, _currentMainCameraTransform.position.y, transform.position.z);
    }
}
