using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class oscillator : MonoBehaviour
{
    [SerializeField] Vector3 movementVector;
    // Start is called before the first frame update

    [Range(0, 1)] [SerializeField] float movementFactor;

    Vector3 startingPos;

    void Start()
    {
        startingPos= transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 offset = movementFactor * movementVector;
        transform.position = startingPos + offset; 
    }
}
