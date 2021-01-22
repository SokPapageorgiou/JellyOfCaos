using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionGround : MonoBehaviour
{
    private bool _collisionGround;

    private void Update()
    {
        GetComponent<PlayerScriptObjLoader>().playerData.collisionGround = _collisionGround;
    }
    
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
            _collisionGround = true;
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
            _collisionGround = false;
    }
}
