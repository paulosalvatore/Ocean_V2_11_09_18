using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jogador : MonoBehaviour {

	public GameObject projetilPrefab;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			Atirar();
		}
	}

	private void Atirar()
	{
		GameObject projetil = Instantiate(projetilPrefab);
		projetil.transform.position = Camera.main.transform.position;
		projetil.transform.forward = Camera.main.transform.forward;
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("Zumbi"))
		{
			SceneManager.LoadScene(0);
		}
	}
}
