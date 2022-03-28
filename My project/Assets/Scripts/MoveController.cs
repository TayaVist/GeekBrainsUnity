using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{

    [SerializeField]
    private float Speed = 2;
    [SerializeField]
    private GameObject Zombie;
    [SerializeField]
    private Transform[] points;

    // Start is called before the first frame update
    void Start()
    {
        int index = Random.Range(0, points.Length);
        var newGO = Instantiate(Zombie, points[index].position, Quaternion.identity);
        //Destroy(newGO);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) {
            Debug.Log("Space key pressed");
        }

        var a = Input.GetAxis("Horizontal");
        var b = Input.GetAxis("Vertical");

        var direction = new Vector3(a, 0, b);

        //transform.position = transform.position + Speed * direction * Time.deltaTime;
        transform.Translate(Speed * direction * Time.deltaTime);

        Debug.Log(a);
        Debug.Log(b);

        
    }
}
