using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    private bool _collisionGround;
    private float _jumpForce;

    private Rigidbody _rigidBody;

    void Start()
    {
        _jumpForce = GetComponent<PlayerScriptObjLoader>().playerData.jumpForce;
        _rigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        _collisionGround = GetComponent<PlayerScriptObjLoader>().playerData.collisionGround;
        Jump();
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _collisionGround)
            _rigidBody.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
    }
}
