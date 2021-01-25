using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Player", menuName = "ScriptableObjects/Player")]
public class PlayerData : ScriptableObject
{
    public bool collisionGround;
    public float gravityForce;
    public float jumpForce;
    
}
