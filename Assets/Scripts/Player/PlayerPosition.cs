using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerTransform 
{
    public class PlayerTransformTrack 
    {
        public Transform GetPlayerTransform() 
        {
            Transform _playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
            
            return _playerTransform;
        }
    }

}
