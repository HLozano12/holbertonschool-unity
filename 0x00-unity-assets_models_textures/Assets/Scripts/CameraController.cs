using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public Transform target;
    private Vector3 targetOffset;

    public float dragSpeed = 2;
    private Vector3 dragOrigin;
    private float X;
    private float Y;

    // Called at first frame
    void Start()
    {
        target = player.transform;
        targetOffset = transform.position - target.position;
    }

    // called once per frame
    void Update()
    {
        // Linear Interpolation LERP
        transform.position = Vector3.Lerp(transform.position, target.position+targetOffset, 0.1f);

        // When Mouse is clicked
        if (Input.GetMouseButtonDown(0))
        {
            transform.Rotate(new Vector3(Input.GetAxis("Mouse Y") * dragSpeed, -Input.GetAxis("Mouse X") * dragSpeed, 0));
            return;
        }
        if (!Input.GetMouseButton(0)) return;
        X = transform.rotation.eulerAngles.x;
        Y = transform.rotation.eulerAngles.y;
        transform.rotation = Quaternion.Euler(X, Y, 0);

        Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - dragOrigin);
        Vector3 move = new Vector3(pos.x * dragSpeed, 0, pos.y * dragSpeed);
        transform.Rotate(-move, Space.World);
    }
}	
