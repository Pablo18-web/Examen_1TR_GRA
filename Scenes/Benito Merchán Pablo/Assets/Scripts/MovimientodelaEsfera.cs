using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientodelaEsfera : MonoBehaviour
{

	public float speed;
	// Use this for initialization
	void Start()
	{

		speed = 70f;

	}

	// Update is called once per frame
	void Update()
	{
		MoverEsfera();
	}

	void MoverEsfera()
	{
		
		float desplZ = Input.GetAxis("Vertical");
		transform.Translate(Vector3.right * Time.deltaTime * speed * desplZ);
		
		float desplX = Input.GetAxis("Horizontal");
		transform.Translate(Vector3.right * Time.deltaTime * speed * desplX);



		float PosX = transform.position.x;
		float PosZ = transform.position.z;

		if (PosX > -95 && PosX < 95)
		{
			transform.Translate(Vector3.right * Time.deltaTime * speed * desplX);
		}

		else if (PosX < -95 && desplX > 0)
		{
			transform.Translate(Vector3.right * Time.deltaTime * speed * desplX);

		}

		else if (PosX > 95 && desplX < 0)
		{
			transform.Translate(Vector3.right * Time.deltaTime * speed * desplX);
		}

		
		if (PosZ > -95 && PosZ < 95)
		{
			transform.Translate(Vector3.forward * Time.deltaTime * speed * desplZ);
		}

		else if (PosZ < -95 && desplZ > 0)
		{
			transform.Translate(Vector3.forward * Time.deltaTime * speed * desplZ);

		}

		else if (PosZ > 95 && desplZ < 0)
		{
			transform.Translate(Vector3.forward * Time.deltaTime * speed * desplZ);





		}
		}
		
	}

