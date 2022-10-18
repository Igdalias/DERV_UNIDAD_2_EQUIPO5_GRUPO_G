using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Deteccion_Colisiones_V2 : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI txt_vida_enemigo;
    [SerializeField]
    TextMeshProUGUI txt_ataque_enemigo;


    // Start is called before the first frame update
    void Start()
    {
        int v = Singleton_Usuario.instancia.vida;
        int a = Singleton_Usuario.instancia.ataque;

        txt_vida_enemigo.text = v.ToString();
        txt_ataque_enemigo.text = a.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        string name;
        string tag;

        name = collision.gameObject.name;
        tag = collision.gameObject.tag;

        Debug.Log("Enter - Nombre: " + name + " Tag: " + tag);

        if (!tag.Equals("Escenario"))
        {
            GameObject obj = GameObject.Find(name);
            Destroy(obj, 5);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        string name;

        string tag;

        name = collision.gameObject.name;
        tag = collision.gameObject.tag;

        Debug.Log("Exit - Nombre: " + name + " Tag: " + tag);
    }

    private void OnCollisionExit(Collision collision)
    {
        string name;
        string tag;

        name = collision.gameObject.name;
        tag = collision.gameObject.tag;

        Debug.Log("Exit - Nombre: " + name + " Tag: " + tag); 
    }
}
