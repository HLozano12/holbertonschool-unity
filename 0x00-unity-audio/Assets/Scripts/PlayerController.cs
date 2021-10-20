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
		public float speed = 10.0F;
		public float JumpHeight = 50.0F;

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
				Debug.Log(Input.GetAxis("Jump"));
			}
			

		}

		void Update()
    	{
        // Respwan when fallen < -15 on y axis
        
        	if (player.transform.position.y < -5)
        	{
            	rb.velocity = new Vector3(0, 0, 0);
            	player.transform.position = Respawn.transform.position;
            
              
        	}
    
    	}

		void OnCollisionEnter(Collision Hit)
		{
			if (Hit.gameObject.tag == "Floor")
			{
				isGround = true;
			}
		}

		void OnCollisionExit(Collision Off)
		{
			if (Off.gameObject.tag == "Floor")
			{
				isGround = false;
			}
		}
	}
