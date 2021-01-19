using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CameraListner;

public class PlayerGravity : MonoBehaviour
{
    private float _cameraZAngle;
    private float _gravityForce;
    
    private Rigidbody _rigidBody;
    private CameraOutput _cameraOutput;

    private void Start()
    {
        _gravityForce = GetComponent<PlayerScriptObjLoader>().playerData.gravityForce;
        _rigidBody = GetComponent<Rigidbody>();
        _cameraOutput = new CameraOutput();
    }

    private void FixedUpdate()
    {
        _cameraZAngle = _cameraOutput.GetZRotation();
        _rigidBody.AddForce(SetGravityDirection());
    }

    private Vector3 SetGravityDirection()
    {
        float _gravityX = Mathf.Sin(_cameraZAngle * Mathf.PI / 180) * _gravityForce;
        float _gravityY = Mathf.Cos(_cameraZAngle * Mathf.PI / 180) * _gravityForce * -1;
        float _gravityZ = 0;

        return new Vector3(_gravityX, _gravityY, _gravityZ);
    }
}
