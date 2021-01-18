using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CameraRotation 
{
    public class CameraRotation : MonoBehaviour
    {
        private float _xRotation;
        private float _yRotation;
        private float _zRotation;
        
        private float _zSpeed;
        private float _zAngleLimit;

        private Transform _player;
        private Transform _lookAt;

        private void Start()
        {
            _zSpeed = GetComponent<CameraScriptObjLoader>().cameraData.rotationSpeedZ;
            _zAngleLimit = GetComponent<CameraScriptObjLoader>().cameraData.rotationLimitZ;

            _player = GameObject.FindGameObjectWithTag("Player").transform;
        }

        private void Update()
        {
            FullRotation();
        }


        private void FullRotation() 
        {
            transform.LookAt(_player);
            transform.Rotate(0,0,ZRotation());
        }
        
        private float XRotation() 
        {
            if (_player.position.y == transform.position.y)
                _xRotation = 0;
            else
                _xRotation = Mathf.Atan(_player.position.y - transform.position.z/ _player.position.y - transform.position.y) * (180 / Mathf.PI);
            
            return _xRotation;
        }

        private float YRotation()
        {
            if (_player.position.x == transform.position.x)
                _yRotation = 0;
            else
                _yRotation = Mathf.Atan(_player.position.z - transform.position.z / _player.position.x - transform.position.x) * (180 / Mathf.PI);

            return _yRotation;
        }

        private float ZRotation()
        {
            _zRotation += Input.GetAxis("Horizontal") * _zSpeed * Time.deltaTime;
            _zRotation = Mathf.Clamp(_zRotation, _zAngleLimit * -1, _zAngleLimit);

            return _zRotation;
        }
    }
}
