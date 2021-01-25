using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayerListner;

namespace CameraRotation 
{
    public class CameraRotation : MonoBehaviour
    {
        private float _z;
        private float _zSpeed;
        private float _zSpeedRecovery;
        private float _zAngleLimit;
        private float _zThreshold;
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
            _zThreshold = GetComponent<CameraScriptObjLoader>().cameraData.rotationZThreshold;

            _playerOutput = new PlayerOutput();
        }

        private void Update()
        {
            transform.LookAt(_playerOutput.GetPlayerTransform());
            ZRotation();
            transform.Rotate(transform.rotation.x, transform.rotation.y, _z);
        }

        private void ZRotation()
        {
            if (_playerOutput.GetPlayerCollisionGround())
                ZInput();
            
            if (_zNeedsRecovery && !_playerOutput.GetPlayerCollisionGround())
                ZBackToZero();
            }

        private void ZInput()
        {
            _z += Input.GetAxis("Horizontal") * _zSpeed * Time.deltaTime;
            _z = Mathf.Clamp(_z, -_zAngleLimit, _zAngleLimit);

            _zNeedsRecovery = true;
        }

        private void ZBackToZero()
        {
            if (_z > _zThreshold)
                _z -= _zSpeedRecovery * Time.deltaTime;

            else if (_z < _zThreshold)
                _z += _zSpeedRecovery * Time.deltaTime;

            else
            {
                _z = 0;
                _zNeedsRecovery = false;
            }
        }
    }
}
