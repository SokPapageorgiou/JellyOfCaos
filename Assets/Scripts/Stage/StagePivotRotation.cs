using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StagePivotRotation : MonoBehaviour
{
    private float _horizontalInput;
    private float _angleRotationMaxDegrees;

    private void Start()
    {
        _angleRotationMaxDegrees = GetComponent<StagePivotScriptObjLoader>().stageData.angleRotationMaxDegrees;
    }

    void Update()
    {
        _horizontalInput = Input.GetAxis("Horizontal");
        RotateTowardsMaxAngle(_horizontalInput);
    }

    private void RotateTowardsMaxAngle(float _horizontalInput)
    {
        
        float _targetZrotation = _horizontalInput * _angleRotationMaxDegrees;
        transform.localEulerAngles = new Vector3(0, 0, _targetZrotation);
    }
}
