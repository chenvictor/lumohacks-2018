using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public float Speed;             //Floating point variable to store the player's movement speed.

    public Animator animator;

	private GameObject boundObj = null;
	private Vector3 boundOffset;

	private bool canMove = true;

    private Rigidbody2D rb2d;       //Store a reference to the Rigidbody2D component required to use 2D Physics.

    // Use this for initialization
    void Start()
    {
		Debug.Log ("PlayerController start");
        //Get and store a reference to the Rigidbody2D component so that we can access it.
        rb2d = GetComponent<Rigidbody2D>();
    }

	public void setEnabled(bool enabled) {
		canMove = enabled;
        if (!enabled)
        {
            animator.SetFloat("Speed", 0.0f);
        }
	}

	public void bindObject(GameObject obj) {
		if (boundObj != null) {
			//end any animations
			boundObj.GetComponent<Animator> ().SetBool ("animate", false);
		}
		boundObj = obj;
		if (boundObj != null) {
			boundOffset = obj.transform.position - transform.position;
		}
	}

    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void FixedUpdate()
    {
		Debug.Log ("Move: " + canMove);
		if (!canMove) {
			Debug.Log ("eject");
			return;
		}
        //Store the current horizontal input in the float moveHorizontal.
        float moveHorizontal = 0;

        //Store the current vertical input in the float moveVertical.
        float moveVertical = 0;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            animator.SetFloat("Speed", 0.06f);
            Speed = 0.06f;
            moveHorizontal = 0.06f;
        } else
        {
            animator.SetFloat("Speed", 0.0f);
            Speed = 0;
        }

        //Use the two store floats to create a new Vector2 variable movement.
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        //Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.
        rb2d.MovePosition(rb2d.position + movement);
		if (boundObj != null) {
			boundObj.transform.position = transform.position + boundOffset;
			if (movement.magnitude > 0) {
				boundObj.GetComponent<Animator> ().SetBool ("animate", true);
			} else {
				boundObj.GetComponent<Animator> ().SetBool ("animate", false);
			}
		}
    }
}