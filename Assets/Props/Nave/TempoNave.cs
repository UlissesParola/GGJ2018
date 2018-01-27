using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TempoNave : MonoBehaviour
{
    public float TempoDaFase;

    private float _tempoFinal;
    private Image _imagemNave;
    private float _extensaoPosicaoNave;
    private float _posicaoInicialNave;

	void Start ()
	{
	    _extensaoPosicaoNave = 150;
	    _posicaoInicialNave = transform.position.y;
	    _tempoFinal = Time.time + TempoDaFase;
	    _imagemNave = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
	    if (Time.time <= _tempoFinal)
	    {
	        AtualizaPosicaoNave();
	    }
	}

    private void AtualizaPosicaoNave()
    {
        float porcTempo = Time.time / TempoDaFase;
        float variacaoPosicaoY = (_extensaoPosicaoNave * porcTempo);
        Debug.Log(variacaoPosicaoY  + _posicaoInicialNave);
        Vector2 novaPosicao = new Vector2(transform.position.x, _posicaoInicialNave + variacaoPosicaoY );
        _imagemNave.transform.position = novaPosicao;
    }
}
