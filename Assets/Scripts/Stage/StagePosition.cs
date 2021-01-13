using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CameraListner;

public class StagePosition : MonoBehaviour
{
    private CameraOutput _cameraOutput = new CameraOutput();
    private Transform _currentMainCameraPosition;

    // Update is called once per frame
    void Update()
    {
        _currentMainCameraPosition = _cameraOutput.GetMainCameraTransform();

        transform.position = new Vector3(_currentMainCameraPosition.position.x * -1, _currentMainCameraPosition.position.y * -1, transform.position.y);
    }
}
