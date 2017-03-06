using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharControllScript : MonoBehaviour{

	public float maxSpeed = 15f;
	bool facingRight = true;
	Animator anim;

	bool grounded = false;
	public Transform groundCheck;
	float groundRadius = .02f;
	public LayerMask whatIsGround;
	public float jumpForce = 800f;
	bool doubleJump = false; 

	public static Vector3 spawnPosition;

	void Start ()	{
		anim = GetComponent<Animator> ();
		GetComponent<Rigidbody2D> ().freezeRotation = true;
		transform.position = spawnPosition;
	}

	void FixedUpdate ()	{

		grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, whatIsGround);
		anim.SetBool ("Ground", grounded);

		anim.SetFloat ("vSpeed", GetComponent<Rigidbody2D>().velocity.y);

		float move = Input.GetAxis ("Horizontal"); 
		anim.SetFloat ("Speed", Mathf.Abs (move));
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (move * maxSpeed, GetComponent<Rigidbody2D> ().velocity.y);

		if (move > 0 && !facingRight)
			Flip ();
		else if (move < 0 && facingRight)
			Flip ();
	}

	void Update (){
		if (Input.GetKeyDown (KeyCode.Space)) {
			if (grounded) {
				anim.SetBool ("Ground", false);
				GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x, 0f);   
				GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0f, jumpForce)); 
				doubleJump = true;
			} else if (doubleJump) {
				doubleJump = false;
				GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x, 0f);  
				GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0f, jumpForce)); 
			}
		}
	}

void Flip () {
	facingRight = !facingRight;
	Vector3 theScale = transform.localScale;
	theScale.x *= -1;
	transform.localScale = theScale;
}

void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Exit") {
				ExitScript theOtherExit = other.GetComponent<ExitScript> ();
				spawnPosition = theOtherExit.positionOfPlayerInNextScene;

				SceneManager.LoadScene (theOtherExit.sceneToExitTo);

			}
		}
	}
