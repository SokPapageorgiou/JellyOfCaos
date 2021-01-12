using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayerTransform;
using CameraMovement;


namespace CameraController 
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField]
        private float _speedMetersPerSecond = 0;
        
        private PlayerTransformTrack _playerTransform = new PlayerTransformTrack();
        private CameraJourney _cameraMovement = new CameraJourney();
        private Transform _currentPlayerTransform; 

        void Update()
        {
            _currentPlayerTransform = _playerTransform.GetPlayerTransform();
            transform.LookAt(_currentPlayerTransform);
            transform.position = _cameraMovement.MoveCameraToDestination(transform.position, _currentPlayerTransform.position, _speedMetersPerSecond);            
        }
    }

}
