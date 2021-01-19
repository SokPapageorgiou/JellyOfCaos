using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayerListner;

namespace CameraRotation 
{
    public class CameraRotation : MonoBehaviour
    {
        private float _zRotation;
        private float _zSpeed;
        private float _zAngleLimit;

        private PlayerOutput _playerOutput;
        
        private void Start()
        {
            _zSpeed = GetComponent<CameraScriptObjLoader>().cameraData.rotationZSpeed;
            _zAngleLimit = GetComponent<CameraScriptObjLoader>().cameraData.rotationZLimit;

            _playerOutput = new PlayerOutput();
        }

        private void Update()
        {
            FullRotation();
        }


        private void FullRotation() 
        {
            transform.LookAt(_playerOutput.GetPlayerTransform());
            transform.Rotate(transform.rotation.x, transform.rotation.y, ZRotation());
        }
        
        private float ZRotation()
        {
            _zRotation += Input.GetAxis("Horizontal") * _zSpeed * Time.deltaTime;
            _zRotation = Mathf.Clamp(_zRotation, _zAngleLimit * -1, _zAngleLimit);

            return _zRotation;
        }
    }
}
