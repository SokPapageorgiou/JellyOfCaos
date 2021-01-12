using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace PlayerController
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField]
        private float _speedMetersPerSecond = 0;

        private float _horizontalMovement;
        private float _verticalMovement;

        void Update()
        {
            _horizontalMovement = Input.GetAxis("Horizontal") * _speedMetersPerSecond * Time.deltaTime * -1;
            _verticalMovement = Input.GetAxis("Vertical") * _speedMetersPerSecond * Time.deltaTime;

            transform.Translate(_horizontalMovement, _verticalMovement, 0);
        }
    }

}
