using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerListner 
{
    public class PlayerOutput 
    {
        public Transform GetPlayerTransform() 
        {
            Transform _playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
            
            return _playerTransform;
        }
    }

}
