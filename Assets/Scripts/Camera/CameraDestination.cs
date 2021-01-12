using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CameraMovement
{
    public class CameraJourney
    {
        public Vector3 MoveCameraToDestination(Vector3 currentPosition, Vector3 target, float _speedMetersPerSecond)
        {
            Vector3 finalPosition = new Vector3(target.x, target.y, currentPosition.z);
            return Vector3.MoveTowards(currentPosition, finalPosition, _speedMetersPerSecond * Time.deltaTime);
        }
    } 
}

