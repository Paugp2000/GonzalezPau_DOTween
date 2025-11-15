using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHUDController : MonoBehaviour
{
    [SerializeField] public Button playSimulation;
    public Cube1Controller cube1Controller;
    public CubeParController cubeParController;

    public void CallMethodsPlay()
    {
        cube1Controller.saltarEncimaPared();
        cubeParController.Actuacion();
    }
    public void ResetMethods()
    {
        cube1Controller.devolverPosicionInicial();  
        cubeParController.volverAlInicio();
    }
}
