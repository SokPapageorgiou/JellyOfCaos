using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Stage", menuName = "ScriptableObjects/Stage")]
public class StageData : ScriptableObject
{
    public float angleRotationMaxDegrees;
    public float speedMetersPerSecond;
}
