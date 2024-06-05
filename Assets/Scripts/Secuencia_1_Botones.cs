using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Secuencia_1_Botones : MonoBehaviour
{
    public Button Sosa;
    public Button A�adir;

    public GameObject EnvaseSosa; // Asigna el GameObject del modelo aqu�
    public GameObject CucharaSosa; // Asigna el GameObject del modelo aqu�
    private Animator animator; // Referencia al Animator del modelo



    private Button firstPressedButton;//Almacena el bot�n presionado primero
    private bool isSecondButtonPending = false;//Bandera para indicar si se est� esperando el segundo bot�n


    private void Start()
    {
        animator = EnvaseSosa.GetComponent<Animator>(); // Obtiene el Animator del modelo
        animator = CucharaSosa.GetComponent<Animator>(); // Obtiene el Animator del modelo


    }
    
    public void OnButton1Down()
    {
        firstPressedButton = Sosa;
        isSecondButtonPending = true;
        animator.Play("Envase Rotaci�n"); // Reproduce la animaci�n predeterminada

    }

    public void OnButton2Down()
    {
        if (isSecondButtonPending)
        {
            ActivateModel(); // Activa el modelo antes de la animaci�n
            animator.Play("CucharaSosa"); // Reproduce la animaci�n predeterminada
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
