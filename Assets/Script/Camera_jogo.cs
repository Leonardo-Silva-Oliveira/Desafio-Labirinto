using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_jogo : MonoBehaviour
{
    Vector3 c;
    public enum RotationAxes
    {
        MouseXAndY = 0,
        MouseX = 1,
        MouseY = 2
    }
    public RotationAxes axes = RotationAxes.MouseXAndY;
    public float sensitivityHor = 2.5f;
    public float sensitivityVert = 2.5f;
    public float maximumVert = 25.0f;
    public float minimumVert = -25.0f;
    private float _rotationX = 0;
    // Start is called before the first frame update
    void Start()
    {
        c.x = 0.0f;
        c.y = 0.0f;
        c.z = 0.0f;
        Rigidbody body = GetComponent<Rigidbody>();
        if (body != null)
            body.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            c.x = 0.03f;
            Movimentar(c);
            Debug.Log("D");
            c.x = 0.0f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            c.x = -0.03f;
            Movimentar(c);
            Debug.Log("A");
            c.x = 0.0f;
        }
        if (Input.GetKey(KeyCode.W))
        {
            c.z = 0.03f;
            Movimentar(c);
            Debug.Log("W");
            c.z = 0.0f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            c.z = -0.03f;
            Movimentar(c);
            Debug.Log("S");
            c.z = 0.0f;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            c.y = 0.03f;
            Movimentar(c);
            Debug.Log("Espaço");
            c.y = 0.0f;
        }
        if (Input.GetKey(KeyCode.LeftControl))
        {
            c.y = -0.03f;
            Movimentar(c);
            Debug.Log("Control esquerdo");
            c.y = 0.0f;
        }
        if (axes == RotationAxes.MouseX)
        {
            transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivityHor, 0);
        }
        else if (axes == RotationAxes.MouseY)
        {
            _rotationX -= Input.GetAxis("Mouse Y") * sensitivityVert;
            _rotationX = Mathf.Clamp(_rotationX, minimumVert, maximumVert);
            float rotationY = transform.localEulerAngles.y;
            transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);
        }
        else
        {
            _rotationX -= Input.GetAxis("Mouse Y") * sensitivityVert;
            _rotationX = Mathf.Clamp(_rotationX, minimumVert, maximumVert);
            float delta = Input.GetAxis("Mouse X") * sensitivityHor;
            float rotationY = transform.localEulerAngles.y + delta;
            transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);
        }
    }
    void Movimentar(Vector3 c)
    {
        transform.Translate(c);
    }
}
