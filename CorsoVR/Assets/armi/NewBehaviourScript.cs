using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KunaiSpawner : MonoBehaviour
{
    // L'asset del proiettile
    [serializeField]
    private GameObjet proiettile;
 
    // il punto da dove parte il proiettile
    [serializeField]
    private Transform firePoint;

    //L'azione che l'utente fa per sparare
    [serializeField]
    private InputActionReference shootAction;

   

    // Update is called once per frame
    void Update()
    {
        /*
         shootAction.action.WasPressedThisFrame() =>
         se ho premuto in questo frame da come valore vero 
         altrimenti da come valore falso
        */
        if(shootAction.action.WasPressedThisFrame())
        {
            /*
              Instantiate => Crea
              crea il proiettil nella posizione firePoint.position, con firePoint.rotation

            */
           Instantiate(proiettile, firePoint.position, firePoint.rotation)
        }
    }
}
