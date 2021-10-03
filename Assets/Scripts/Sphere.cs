using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 
/// </summary>
[RequireComponent(typeof(Animator))]
public class Sphere : GeometricPrimitive
{
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = target.position + distanceFromTarget;
        transform.localScale = scale;
        renderer = GetComponent<Renderer>();
        renderer.material = material;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(target.position, rotationAxis, rotationSpeed * Time.deltaTime);
    }
}
