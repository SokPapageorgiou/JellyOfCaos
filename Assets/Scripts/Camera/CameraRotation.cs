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
        private float _zSpeedRecovery;
        private float _zAngleLimit;
        private bool _zNeedsRecovery;

        private PlayerOutput _playerOutput;

        private void Awake()
        {
            _zNeedsRecovery = false;
        }

        private void Start()
        {
            _zSpeed = GetComponent<CameraScriptObjLoader>().cameraData.rotationZSpeed;
            _zSpeedRecovery = GetComponent<CameraScriptObjLoader>().cameraData.rotationZSpeedRecovery;
            _zAngleLimit = GetComponent<CameraScriptObjLoader>().cameraData.rotationZLimit;

            _playerOutput = new PlayerOutput();
        }

        private void Update()
        {
            transform.LookAt(_playerOutput.GetPlayerTransform());

            if (_playerOutput.GetPlayerCollisionGround())
            {
                _zRotation += Input.GetAxis("Horizontal") * _zSpeed * Time.deltaTime;
                _zRotation = Mathf.Clamp(_zRotation, _zAngleLimit * -1, _zAngleLimit);

                _zNeedsRecovery = true;
            }
            
            if (_zNeedsRecovery && !_playerOutput.GetPlayerCollisionGround())
            {
                if (_zRotation > 1)
                    _zRotation -= _zSpeedRecovery * Time.deltaTime;

                else if (_zRotation < 1)
                    _zRotation += _zSpeedRecovery * Time.deltaTime;

                else 
                {
                    _zRotation = 0;
                    _zNeedsRecovery = false;
                }    
            }            

            transform.Rotate(transform.rotation.x, transform.rotation.y, _zRotation);
        }    
    }
}
