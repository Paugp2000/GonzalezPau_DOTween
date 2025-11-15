using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeParController : MonoBehaviour
{
    [SerializeField] Rigidbody rbDorado;
    [SerializeField] Rigidbody rbPlateado;
    [SerializeField] Transform puntoDeLlegada1;
    [SerializeField]Transform puntoDeLlegada2;
    [SerializeField] Transform puntoDeChoque;
    [SerializeField] public Vector3 rotationFinal = new Vector3 (0, 30, 1080);
    private Vector3 posicionInicialDorado;
    private Vector3 posicionInicialPlateado;

    private void Start()
    {
        posicionInicialDorado = rbDorado.transform.position;
        posicionInicialPlateado = rbPlateado.transform.position;
    }
    public void Actuacion()
    {
        DOTween.Sequence().
           Append(rbDorado.DOMove(puntoDeLlegada1.position, 5f)).
           Join(rbPlateado.DOMove(puntoDeLlegada2.position, 5f)).
           Append(rbDorado.DOJump(puntoDeChoque.position, 10f, 1, 3f)).
           Join(rbPlateado.DOJump(puntoDeChoque.position, 10f, 1, 3f)).
           Append(rbDorado.DORotate(rotationFinal, 3f).SetRelative(true)).
           Join(rbPlateado.DORotate(rotationFinal, 4f).SetRelative(true)).
           OnComplete(() => { Debug.Log("Tachan"); });

    }
    public void volverAlInicio()
    {
        rbDorado.transform.position = posicionInicialDorado;
        rbPlateado.transform.position= posicionInicialPlateado;
    }
}
