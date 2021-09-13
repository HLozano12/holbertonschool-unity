using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

    public class PlayerController : MonoBehaviour
    {
		// Controls of player movement
        public GameObject Player;
		private Rigidbody rb;
		public float speed = 10.0F;
		public float JumpSpeed = 10.0F;
		public float Gravity = -10.0F;
		public float JumpHeight = 5.0F;

		// Player control
		public bool isGround;
		private Vector3 control;

		// To be called at first frame update
		void Start()
		{
			rb = GetComponent<Rigidbody>();
			isGround = true;
		}

		// controls Movement of player
		void FixedUpdate()
		{
			if (isGround == true)
			{	
				rb.velocity = new Vector3(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Jump") * JumpHeight, Input.GetAxis("Vertical") * speed);
			}
		}








    }
