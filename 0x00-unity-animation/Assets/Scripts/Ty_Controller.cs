using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ty_Controller : MonoBehaviour
{
	private Animator Ani;
	public GameObject player;
	public float jumping;
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

		jumping = Input.GetAxis("jump");

		 // Running
        if (xAxis != 0 || yAxis != 0)
        {
            Ani.SetBool("isRunning", true);
        }

        if (xAxis == 0 && yAxis == 0)
        {
            Ani.SetBool("isRunning", false);
        }
        
        // Jump
        if (TyControl.isGround == false)
        {
            // isJumping = true;
            Ani.SetBool("isJumping", true);
        }

        else
        {
            Ani.SetBool("isJumping", false);
        }

        // Falling
        if (player.transform.position.y < -14)
        {
            Debug.Log("Player should be falling");
            // isfalling = true;
            Ani.SetBool("isFalling", true);

        }

        if (TyControl.isGround == true)
        {
            Ani.SetBool("isFalling", false);
        }
        
    }
}
