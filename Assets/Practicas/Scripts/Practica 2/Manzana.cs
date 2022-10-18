using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Manzana : MonoBehaviour
{


    [SerializeField]
    public TextMeshProUGUI txt_Vida;
    int vida;



    private void Awake()
    {
        GameObject obj = GameObject.Find("txt_Vida");
        txt_Vida = obj.GetComponent<TextMeshProUGUI>();
    }

    // Start is called before the first frame update
    void Start()
    {
        vida = 100;
        StopAllCoroutines();
        StartCoroutine("Perdida_vida");
        txt_Vida.text = vida.ToString();
    }

    // Update is called once per frame
    void Update()
    {



    }

    private void OnCollisionEnter(Collision collision)
    {

        string nombre;
        string tag;

        nombre = collision.gameObject.name;
        tag = collision.gameObject.tag;

        if (!tag.Equals("Escenario"))
        {
            GameObject objeto = GameObject.Find(nombre);
            GameObject.Destroy(objeto, 0);
            while(vida < 100)
            {
                vida = vida + 5;
                txt_Vida.text = vida.ToString();
            }
            
        }
    }

    IEnumerator Perdida_vida()
    {

        while (vida >= 0);
        {
            txt_Vida.text = vida.ToString();
            vida = vida - 5;
            yield return new WaitForSeconds(1f);
        }
    }

}
