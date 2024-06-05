using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Secuencia_1_Botones : MonoBehaviour
{
    public Button Sosa;
    public Button Añadir;

    public GameObject EnvaseSosa; // Asigna el GameObject del modelo aquí
    public GameObject CucharaSosa; // Asigna el GameObject del modelo aquí
    private Animator animator; // Referencia al Animator del modelo



    private Button firstPressedButton;//Almacena el botón presionado primero
    private bool isSecondButtonPending = false;//Bandera para indicar si se está esperando el segundo botón


    private void Start()
    {
        animator = EnvaseSosa.GetComponent<Animator>(); // Obtiene el Animator del modelo
        animator = CucharaSosa.GetComponent<Animator>(); // Obtiene el Animator del modelo


    }
    
    public void OnButton1Down()
    {
        firstPressedButton = Sosa;
        isSecondButtonPending = true;
        animator.Play("Envase Rotación"); // Reproduce la animación predeterminada

    }

    public void OnButton2Down()
    {
        if (isSecondButtonPending)
        {
            ActivateModel(); // Activa el modelo antes de la animación
            animator.Play("CucharaSosa"); // Reproduce la animación predeterminada
            isSecondButtonPending = false;
        }
    }

    public void ActivateModel()

    {
        CucharaSosa.SetActive(true);
    }

    public void DeactivateModel()
    {
        CucharaSosa.SetActive(false);
    }

}
