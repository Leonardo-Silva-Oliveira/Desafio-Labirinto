using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class velocidade1 : MonoBehaviour
{
    public float velocidade = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.M))
        {
            float deltaX = Input.GetAxis("Horizontal") * velocidade;
            float deltaZ = Input.GetAxis("Vertical") * velocidade;
            Vector3 movimento = new Vector3(deltaX, 0, deltaZ);
            movimento = Vector3.ClampMagnitude(movimento, velocidade);
            movimento *= Time.deltaTime;
            movimento = transform.TransformDirection(movimento);
        }
    }
}
