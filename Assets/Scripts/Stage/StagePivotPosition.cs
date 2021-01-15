using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayerListner;
using Positioning;

public class StagePivotPosition : MonoBehaviour
{
    private float _speedMetersPerSecond;
    
    private PlayerOutput _playerOutput = new PlayerOutput();
    private Movement _movement = new Movement();
    
    private void Start()
    {
        _speedMetersPerSecond = GetComponent<StagePivotScriptObjLoader>().stageData.speedMetersPerSecond;
    }

    void Update()
    {
        if (!HaveRotationInput())
          AlignPositionWithPlayer();
    }

    private void AlignPositionWithPlayer()
    {
        Transform _currentPlayerTransform = _playerOutput.GetPlayerTransform();
        transform.position = _movement.MoveToDestinationXY(transform.position, _currentPlayerTransform.position, _speedMetersPerSecond);
    }

    private bool HaveRotationInput()
    {
        bool _haveRotationInput = false;
        
        float _rotationInput = Input.GetAxis("Horizontal");
        if (_rotationInput != 0)
            _haveRotationInput = true;        

        return _haveRotationInput;
    }
}
