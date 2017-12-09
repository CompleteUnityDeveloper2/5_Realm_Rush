using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Unit
{
    Red,
    Green,
    Blue
}

[CreateAssetMenu(menuName = "Wave")]
public class EnemyWaveConfig : ScriptableObject
{
    public float[] triggerTimes;
    public Unit[] units;
}
