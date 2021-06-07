using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravidade : MonoBehaviour
{
    public float gravity = -9.8f;
    public float speed = 6.0f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float deltaX = Input.GetAxis("Horizontal") * speed;
        float deltaZ = Input.GetAxis("Vertical") * speed;
        Vector3 movement = new Vector3(deltaX, 0, deltaZ);
        if (Input.GetKey(KeyCode.P))
        {
            movement.y = gravity;
        }
        movement *= Time.deltaTime;
        movement = transform.TransformDirection(movement);
    }
}
