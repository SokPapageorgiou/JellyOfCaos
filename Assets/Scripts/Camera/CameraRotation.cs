using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CameraRotation 
{
    public class CameraRotation : MonoBehaviour
    {
        private float _zRotation;
        private float _zSpeed;
        private float _zAngleLimit;

        private Transform _player;
        
        private void Start()
        {
            _zSpeed = GetComponent<CameraScriptObjLoader>().cameraData.rotationZSpeed;
            _zAngleLimit = GetComponent<CameraScriptObjLoader>().cameraData.rotationZLimit;

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
        
        private float ZRotation()
        {
            _zRotation += Input.GetAxis("Horizontal") * _zSpeed * Time.deltaTime;
            _zRotation = Mathf.Clamp(_zRotation, _zAngleLimit * -1, _zAngleLimit);

            return _zRotation;
        }
    }
}
