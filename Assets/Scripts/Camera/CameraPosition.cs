using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayerListner;
using Position;



namespace CameraPosition 
{
    public class CameraPosition : MonoBehaviour
    {
        
        private float _positionSpeed;
        
        private PlayerOutput _playerOutput = new PlayerOutput();
        private PositionMovement _cameraMovement = new PositionMovement();
        private Transform _currentPlayerTransform;

        private void Start()
        {
            _positionSpeed = GetComponent<CameraScriptObjLoader>().cameraData.positionSpeed;
            _currentPlayerTransform = _playerOutput.GetPlayerTransform();
        }

        void FixedUpdate()
        {
            transform.position = _cameraMovement.MoveToDestinationXY(transform.position, _currentPlayerTransform.position, _positionSpeed);            
        }
    }

}
