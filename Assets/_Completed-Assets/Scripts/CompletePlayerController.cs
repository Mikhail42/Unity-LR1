using UnityEngine;

public class CompletePlayerController : MonoBehaviour {

	private Rigidbody2D rb2d;	

	void Start()
	{
		rb2d = GetComponent<Rigidbody2D> ();
	}
    
	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		rb2d.AddForce (new Vector2(moveHorizontal, moveVertical));
	}
    
	void OnTriggerEnter2D(Collider2D other) 
	{
		if (other.gameObject.CompareTag ("PickUp")) 
		{
			other.gameObject.SetActive(false);
		}
	}
}
