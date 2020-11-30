using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientodelaEsfera : MonoBehaviour {

	public float speed;
	// Use this for initialization
	void Start () {
		
		speed = 70f;

	}
	
	// Update is called once per frame
	void Update () {
		MoverEsfera();
	}

  void MoverEsfera() {
		
		float desplY = Input.GetAxis("Vertical");
		transform.Translate(Vector3.up * Time.deltaTime * speed * desplY);
		float desplX = Input.GetAxis("Horizontal");
		transform.Translate(Vector3.right * Time.deltaTime * speed * desplX);
		
		
		
		float PosX = transform.position.x;
		float PosY = transform.position.y;

		if (PosX > -95 && PosX < 95)
		{
			transform.Translate(Vector3.right * Time.deltaTime * speed * desplX);
		}

		else if (PosX < -95 && desplX > 0)
		{
			transform.Translate(Vector3.right * Time.deltaTime * speed * desplX);

		}

		else if (PosX > -3 && desplX < 0)
		{
			transform.Translate(Vector3.right * Time.deltaTime * speed * desplX);
		}





	}







}
