using UnityEngine;
using System.Collections;

public class BouncingBallScript : MonoBehaviour 
{
	public int jumpSpeed = 10;
	public bool canJump = false;
	public string myString = "Dion lol";

	void Start ()
	{

	}
	void Update () 
	{
		if (Input.GetButtonDown ("Jump") && canJump == true)
			GetComponent<Rigidbody> ().AddForce (0, jumpSpeed, 0);

		if (Input.GetButtonDown ("Fire1")) {
			jumpSpeed += 100;
			Debug.Log ("Your jump speed is now: " + jumpSpeed);
		}

		if (Input.GetButtonDown ("Fire2")) {
			canJump = true;
			Debug.Log ("Can jump is true");
		}
	}
}
