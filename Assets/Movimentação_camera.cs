using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentação_camera : MonoBehaviour
{
    Vector3 c;

    // Start is called before the first frame update
    void Start()
    {
        c.x = 0.0f;
        c.y = 0.0f;
        c.z = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D)) {
            c.x = 0.03f;
            Movimentar(c);
            Debug.Log("D");
            c.x = 0.0f;
        }
        if (Input.GetKey(KeyCode.A)) {
            c.x = -0.03f;
            Movimentar(c);
            Debug.Log("A");
            c.x = 0.0f;
        }
        if (Input.GetKey(KeyCode.W)) {
            c.z = 0.03f;
            Movimentar(c);
            Debug.Log("W");
            c.z = 0.0f;
        }
        if (Input.GetKey(KeyCode.S)) {
            c.z = -0.03f;
            Movimentar(c);
            Debug.Log("S");
            c.z = 0.0f;
        }
        if (Input.GetKey(KeyCode.Space)) {
            c.y = 0.03f;
            Movimentar(c);
            Debug.Log("Espaço");
            c.y = 0.0f;
        }
        if (Input.GetKey(KeyCode.LeftControl)) {
            c.y = -0.03f;
            Movimentar(c);
            Debug.Log("Control esquerdo");
            c.y = 0.0f;
        }
    }
    void Movimentar(Vector3 c)
    {
        transform.Translate(c);
    }
}
