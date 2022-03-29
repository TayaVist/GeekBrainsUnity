using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{
    [SerializeField]
    public MyScript myScript;
    private BoxCollider _collider;

    //для инициализации, запускается 1 раз, самым первым
    private void Awake()
    {
        _collider = GetComponent<BoxCollider>();
        if (TryGetComponent<BoxCollider>(out var collider)) {
            _collider = collider;
        }
    }
    // Start is called before the first frame update, запускается 1 раз
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _collider.enabled = true;
    }

    void FixedUpdate()
    {
        
    }

    void LateUpdate()
    {
        
    }
}
