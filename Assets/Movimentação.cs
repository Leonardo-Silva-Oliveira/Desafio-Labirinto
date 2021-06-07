using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentação : MonoBehaviour
{
    Vector3 b;
    // Start is called before the first frame update
    void Start()
    {
        b.x = 0.0f;
        b.y = 0.0f;
        b.z = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow)) {
            b.x = 0.03f;
            Movimento(b);
            Debug.Log("Seta para direita");
            b.x = 0.0f;
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            b.x = -0.03f;
            Movimento(b);
            Debug.Log("Seta para esquerda");
            b.x = 0.0f;
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            b.z = 0.03f;
            Movimento(b);
            Debug.Log("Seta para baixo");
            b.z = 0.0f;
        }
        if (Input.GetKey(KeyCode.UpArrow)) {
            b.z = -0.03f;
            Movimento(b);
            Debug.Log("Seta para cima");
            b.z = 0.0f;
        }
        if (Input.GetKey(KeyCode.V))
        {
            b.y = 0.03f;
            Movimento(b);
            Debug.Log("V");
            b.y = 0.0f;
        }
        if (Input.GetKey(KeyCode.B))
        {
            b.y = -0.03f;
            Movimento(b);
            Debug.Log("B");
            b.y = 0.0f;
        }
    }
    void Movimento(Vector3 b) 
    {
        transform.Translate(b);
    }
}
