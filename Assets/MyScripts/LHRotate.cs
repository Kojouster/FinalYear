using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LHRotate : MonoBehaviour
{
    [SerializeField] GameObject LHobj;
    [SerializeField] float rotSpeed = 0.1f;


    // Update is called once per frame
    void Update()
    {
        LHobj.transform.Rotate(0.0f, rotSpeed, 0.0f, Space.World); // rotates capsule 
    }
}
