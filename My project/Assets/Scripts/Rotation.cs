using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] Transform RotatingObject;
    [SerializeField] Transform RotatedObject;
    [Range(0,1)]
    [SerializeField] float factor;
    private float speed = 10f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotatedObject.rotation = Quaternion.Lerp(RotatingObject.rotation, RotatedObject.rotation, speed*Time.deltaTime); 
    }
}
