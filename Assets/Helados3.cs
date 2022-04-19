using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helados3 : MonoBehaviour
{
    public string sabor;
    public float gramos;

    // Start is called before the first frame update
    void Start()
    {
        float precio = gramos * 0.5f;
        float fru = precio * 0.9f;
        

        if(sabor != "fru" & sabor != "cho" & sabor != "ddc")
        {
            Debug.Log("Error, solo ingresar cho, fru o ddc");
        }
        else if(gramos < 250)
        {
            Debug.Log("Error, solo acepta entre 250 y 3000 gramos");
        }
        else if (gramos > 3000)
        {
            Debug.Log("Error, solo acepta entre 250 y 3000 gramos");
        }
        else if (sabor == "fru")
        {
            Debug.Log("Su precio es de " + fru + " pesos");
        }
        else if (sabor == "cho" & sabor == "ddc")
        {
            Debug.Log("Su precio es de " + precio + " pesos");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
