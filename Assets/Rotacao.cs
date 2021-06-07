using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacao : MonoBehaviour
{
    Vector3 a;
    // Start is called before the first frame update
    void Start()
    {
        a.x = 0.0f;
        a.y = 0.0f;
        a.z = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            a.y = 0.5f;
            Rotaçao(a);
            Debug.Log("Z");
            a.y = 0.0f;
        }
        if (Input.GetKey(KeyCode.X))
        {
            a.y = -0.5f;
            Rotaçao(a);
            Debug.Log("X");
            a.y = 0.0f;
        }
    }
    void Rotaçao(Vector3 a)
    {
        transform.Rotate(a);
    }
}
