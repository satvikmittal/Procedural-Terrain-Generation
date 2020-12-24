using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Enemy : ScriptableObject
{
    public float radius;
    public float attackRadius;

    public float speed = 20f;
}
