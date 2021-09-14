using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
		public float speedX = 2.0F;
		public float speedY = 2.0F;
		private float x = 0.0F;
		private float y = 0.0F;

        void Start()
        {
			
        }

		void Update()
		{
			x += speedX * Input.GetAxis("Mouse X");
			y -= speedY * Input.GetAxis("Mouse Y");

			transform.eulerAngles = new  Vector3(y, x, 0.0F);
		}
}
