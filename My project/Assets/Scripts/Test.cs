using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] Transform a;
    [SerializeField] Transform b;
    [SerializeField] float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(Vector3.Distance(a.position, b.position));

        a.position = Vector3.MoveTowards(a.position, b.position, speed*Time.deltaTime);
    }
}
