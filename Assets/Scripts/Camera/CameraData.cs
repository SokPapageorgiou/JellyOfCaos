using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Camera", menuName = "ScriptableObjects/Camera")]
public class CameraData : ScriptableObject
{
    public float positionSpeed;

    public float rotationZLimit;
    public float rotationZSpeed;
    public float rotationZSpeedRecovery;
    public float rotationZThreshold;
 }
