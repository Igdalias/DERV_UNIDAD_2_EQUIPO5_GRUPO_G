using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Control_Tiempo : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI t_tiempo;

    public int tiempoInicio;
    private void Awake()
    {
        GameObject obj = GameObject.Find("txt_Tiempo");
        t_tiempo = obj.GetComponent<TextMeshProUGUI>();
    }
    // Start is called before the first frame update
    void Start()
    {
        tiempoInicio = 100;
        StopAllCoroutines();
        StartCoroutine("controlTiempo");
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator controlTiempo()
    {
        while (tiempoInicio >= 0)
        {
            t_tiempo.text = tiempoInicio.ToString();
            tiempoInicio--;
            yield return new WaitForSeconds(1f);
        }
    }
}
