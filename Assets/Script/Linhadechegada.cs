using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Linhadechegada : MonoBehaviour
{
    public string Venceu;

    void OnTriggerEnter(Collider collider) 
    {
        if (collider.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(Venceu);
        }
    }
}
