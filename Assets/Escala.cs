using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escala : MonoBehaviour
{
    float x, y, z;
    Vector3 scaleChange;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1)) {
            x = Random.Range(0.0f, 1.0f) / 50.0f;
            y = Random.Range(0.0f, 1.0f) / 50.0f;
            z = Random.Range(0.0f, 1.0f) / 50.0f;
            scaleChange.Set(x, y, z);
            escala(scaleChange);
            Debug.Log("1");
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            x = Random.Range(0.0f, -1.0f) / 50.0f;
            y = Random.Range(0.0f, -1.0f) / 50.0f;
            z = Random.Range(0.0f, -1.0f) / 50.0f;
            scaleChange.Set(x, y, z);
            escala(scaleChange);
            Debug.Log("2");
        }
    }
    void escala(Vector3 p)
    {
        transform.localScale += scaleChange;
    }
}
