using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ty_Controller : MonoBehaviour
{
	private Animator Ani;
	public GameObject player;

	public bool isRunning = false;
	public bool isJumping = false;
	public bool isFalling = false;
	public float xAxis;
	public float yAxis;


    // Start is called before the first frame update
    void Start()
    {
		// grab animator
        Ani = this.gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
		// obtain axis control and playercontrol script
		PlayerController TyControl = player.GetComponent<PlayerController>();

		xAxis = Input.GetAxis("Horizontal");
		yAxis = Input.GetAxis("Vertical");


		 // Running
        if (xAxis != 0 || yAxis != 0)
        {
            Ani.SetBool("isRunning", true);
			Debug.Log("isRunning");
        }

        if (xAxis == 0 && yAxis == 0)
        {
            Ani.SetBool("isRunning", false);
			Debug.Log("isGround");
        }

	   // Falling
        if (player.transform.position.y < -5)
        {
            // isfalling = true;
            Ani.SetBool("isFalling", true);
			Debug.Log("Player falling");

        }

        if (TyControl.isGround == true)
        {
            Ani.SetBool("isFalling", false);
			Debug.Log("isGround");
        }

        // Jump
        if (TyControl.isGround == false)
        {
            // isJumping = true;
            Ani.SetBool("isJumping", true);
			Debug.Log("isJumping");
        }

        else
        {
            Ani.SetBool("isJumping", false);
			Debug.Log("isGround");
        }

        
        
    }
}
