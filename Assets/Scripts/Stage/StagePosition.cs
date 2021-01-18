using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Position;
using PlayerListner;

public class StagePosition : MonoBehaviour
{
    private float _speedMetersPerSecond;

    private PlayerOutput _playerOutput = new PlayerOutput();
    private PositionMovement _movement = new PositionMovement();

    private void Start()
    {
        _speedMetersPerSecond = GetComponent<StagePivotScriptObjLoader>().stageData.speedMetersPerSecond;
    }

    void Update()
    {
        CompensatePlayerPosition();
    }

    private void CompensatePlayerPosition()
    {
        Transform _currentPlayerPosition = _playerOutput.GetPlayerTransform();
        Vector3 _targetPosition = new Vector3(_currentPlayerPosition.position.x * -1, _currentPlayerPosition.position.y * -1, transform.position.z);

        transform.localPosition = _movement.MoveToDestinationXY(transform.localPosition, _targetPosition, _speedMetersPerSecond);
    }
}
