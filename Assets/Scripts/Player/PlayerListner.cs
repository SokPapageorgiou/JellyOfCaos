using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerListner 
{
    public class PlayerOutput 
    {
        public Transform GetPlayerTransform()
        {
            Transform _playerTransform = FindPlayer().transform;

            return _playerTransform;
        }

        public bool GetPlayerCollisionGround() 
        {
            bool _collisionGround = FindPlayer().GetComponent<PlayerScriptObjLoader>().playerData.collisionGround;

            return _collisionGround;
        }

        private GameObject FindPlayer()
        {
            return GameObject.FindGameObjectWithTag("Player");
        }
    }

}
