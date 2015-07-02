using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {

	public float moveSpeed = 5;
	public float rotateSpeed = 180;
	public float jumpSpeed = 20;
	public float gravity = 9.8f;

	Vector3 currentMovement;
	void Start () {
	
	}
	
	void Update () {
		CharacterController controller = GetComponent<CharacterController>();

		transform.Rotate (0,Input.GetAxis ("Horizontal") * rotateSpeed * Time.deltaTime ,0);


		currentMovement = new Vector3(0, currentMovement.y ,Input.GetAxis("Vertical") * moveSpeed) ;

		currentMovement = transform.rotation * currentMovement;

		if (!controller.isGrounded)
			currentMovement -= new Vector3 (0, gravity * Time.deltaTime, 0);
		else
			currentMovement.y = 0;
			

		if (controller.isGrounded && Input.GetButtonDown ("Jump"))
			currentMovement.y = jumpSpeed;


		controller.Move (currentMovement * Time.deltaTime);
	}
}
