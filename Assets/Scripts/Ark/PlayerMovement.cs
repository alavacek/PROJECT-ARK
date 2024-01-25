using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public float speed = 5f;
	GameObject nullRef;

    private void Start()
    {
        nullRef.transform.position = Vector3.zero;
    }
    // Update is called once per frame
    void Update()
    {
		transform.position += Vector3.up * Input.GetAxis("Vertical") * speed * Time.deltaTime;
		transform.position += Vector3.right * Input.GetAxis("Horizontal") * speed * Time.deltaTime;

	}
}
