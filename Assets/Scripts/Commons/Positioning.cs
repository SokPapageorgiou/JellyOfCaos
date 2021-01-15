using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Positioning
{
    public class Movement
    {
        public Vector3 MoveToDestinationXY(Vector3 currentPosition, Vector3 target, float _speedMetersPerSecond)
        {
            Vector3 finalPosition = new Vector3(target.x, target.y, currentPosition.z);
            return Vector3.MoveTowards(currentPosition, finalPosition, _speedMetersPerSecond * Time.deltaTime);
        }
    } 
}

