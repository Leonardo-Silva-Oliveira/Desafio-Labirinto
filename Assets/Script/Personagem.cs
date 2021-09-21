using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour
{
    Vector3 a;
    Vector3 b;
    float x, y, z;
    Vector3 scaleChange;
    public float velocidade = 10.0f;
    public float gravity = -9.8f;
    public float speed = 6.0f;
    // Start is called before the first frame update
    void Start()
    {
        a.x = 0.0f;
        a.y = 0.0f;
        a.z = 0.0f;
        b.x = 0.0f;
        b.y = 0.0f;
        b.z = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
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
        if (Input.GetKey(KeyCode.RightArrow))
        {
            b.x = 0.03f;
            Movimento(b);
            //Debug.Log("Seta para direita");
            b.x = 0.0f;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            b.x = -0.03f;
            Movimento(b);
            //Debug.Log("Seta para esquerda");
            b.x = 0.0f;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            b.z = 0.03f;
            Movimento(b);
            //Debug.Log("Seta para baixo");
            b.z = 0.0f;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            b.z = -0.03f;
            Movimento(b);
            //Debug.Log("Seta para cima");
            b.z = 0.0f;
        }
        if (Input.GetKey(KeyCode.V))
        {
            b.y = 0.03f;
            Movimento(b);
            //Debug.Log("V");
            b.y = 0.0f;
        }
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
    void Rotaçao(Vector3 a)
    {
        transform.Rotate(a);
    }
    void Movimento(Vector3 b)
    {
        transform.Translate(b);
    }
    void escala(Vector3 p)
    {
        transform.localScale += scaleChange;
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstaculo")
        {
            Debug.Log("Batida");
            this.transform.position = new Vector3(-3.834f, 0.5f, -3.49f);
        }
    }
}
