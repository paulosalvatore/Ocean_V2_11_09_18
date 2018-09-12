using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zumbi : MonoBehaviour {

	private Animator animator;
	public Rigidbody rb;

	public float delayAndar = 1f;
	public float velocidade = 0.35f;

	private bool andando = false;

	private GameObject jogador;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();

		jogador = GameObject.Find("Jogador");
		transform.LookAt(jogador.transform);

		Invoke("Andar", delayAndar);
	}

	void Andar()
	{
		andando = true;
	}

	// Update is called once per frame
	void Update () {
		if (andando)
		{
			rb.velocity = transform.forward * velocidade;
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Projétil"))
		{
			Destroy(other.gameObject);
			Matar();
		}
	}

	private void Matar()
	{
		andando = false;
		animator.SetTrigger("Die");
	}
}
