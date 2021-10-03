using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// </summary>
public class GeometricPrimitive : MonoBehaviour
{
    [SerializeField] protected Transform target;
    [SerializeField] protected Vector3 scale;
    [SerializeField] protected Vector3 distanceFromTarget;
    [SerializeField] protected Vector3 rotationAxis;
    [SerializeField] protected float rotationSpeed;
    [SerializeField] protected Material material;
    protected Renderer renderer;
}
