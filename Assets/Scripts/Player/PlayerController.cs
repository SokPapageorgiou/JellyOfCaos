using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace PlayerController
{
    public class PlayerController : MonoBehaviour
    {
        private float _speedMetersPerSecond;
        private float _horizontalMovement;
        private float _verticalMovement;

        void Update()
        {
            _speedMetersPerSecond = GetComponent<PlayerScriptObjLoader>().playerData.speedMetersPerSecond;

            //_horizontalMovement = Input.GetAxis("Horizontal") * _speedMetersPerSecond * Time.deltaTime * -1;
            _verticalMovement = Input.GetAxis("Vertical") * _speedMetersPerSecond * Time.deltaTime;

            transform.Translate(0, _verticalMovement, 0);
        }
    }

}
