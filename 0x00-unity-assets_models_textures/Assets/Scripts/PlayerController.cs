using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

    public class PlayerController : MonoBehaviour
    {
		// Controls of player movement
        public GameObject player;
		private Rigidbody rb;
		public float speed = 50.0F;
		public float JumpSpeed = 50.0F;
		public float JumpHeight = 15.0F;
		 public float gravity = -10.0f;

		public Transform Respawn;


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

		void Update()
    	{
        // Respwan when fallen < -15 on y axis
        
        	if (player.transform.position.y < -15)
        	{
            	rb.velocity = new Vector3(0, 0, 0);
            	player.transform.position = Respawn.transform.position;
            
              
        	}
    
    	}
	}
