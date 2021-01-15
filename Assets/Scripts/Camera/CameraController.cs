using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayerListner;
using Positioning;


namespace CameraController 
{
    public class CameraController : MonoBehaviour
    {
        
        private float _speedMetersPerSecond;        
        private PlayerOutput _playerOutput = new PlayerOutput();
        private Movement _cameraMovement = new Movement();
        private Transform _currentPlayerTransform;

        void Update()
        {
            _speedMetersPerSecond = GetComponent<CameraScriptObjLoader>().cameraData.speedMetersPerSecond;
            _currentPlayerTransform = _playerOutput.GetPlayerTransform();
            
            transform.LookAt(_currentPlayerTransform);
            transform.position = _cameraMovement.MoveToDestinationXY(transform.position, _currentPlayerTransform.position, _speedMetersPerSecond);            
        }
    }

}
