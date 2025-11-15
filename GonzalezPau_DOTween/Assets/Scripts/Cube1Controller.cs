using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube1Controller : MonoBehaviour
{
    public Rigidbody rb;
    [SerializeField] public Transform puntoDeSalto;
    private Vector3 posicionInicial;

    private void Start()
    {
        posicionInicial = rb.transform.position;
    }

    public void saltarEncimaPared()
    {
        rb.DOJump(puntoDeSalto.position, 15f, 1, 5f).SetEase(Ease.InBounce);
    }
    public void devolverPosicionInicial()
    {
        rb.transform.position = posicionInicial;
    }
}
