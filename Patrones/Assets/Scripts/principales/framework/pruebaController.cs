using UnityEngine;
using System.Collections;


public class pruebaController :MonoBehaviour {
	public float maxSpeed = 2f;
	bool facingLeft = false;
	Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		/*GameObject ichigo = new GameObject();
		ichigo.AddComponent<Shinigami>();*/

		/*prefab = (GameObject) Resources.Load("Prefabs/MapTiles/GroundTile", typeof(GameObject));
		GameObject clone = Instantiate(prefab, Vector3.zero, Quaternion.identity) as GameObject;
		// Modify the clone to your heart's content
		clone.transform.position = Vector3.one;*/

	}
	
	// Update is called once per frame
	void FixedUpdate(){
		//Moves Left and right along x Axis  
		float move = Input.GetAxis("Horizontal");
		//GameObject o = GameObject.FindGameObjectWithTag("jugadorP");                           
		//o.transform.position = new Vector2(5,5);	
		transform.Translate(Vector2.right * Time.deltaTime * move* maxSpeed);      

		anim.SetFloat ("speed", Mathf.Abs(move));
		GetComponent<Rigidbody2D>().velocity = new Vector3 (move * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);
		
		if (move > 0 && facingLeft)
			Flip ();
		else if (move < 0 && !facingLeft)
			Flip ();
	}

	void Flip(){
		facingLeft = ! facingLeft;
		Vector3 theScale = transform.localScale;
		theScale.x *=  -1;
		transform.localScale = theScale;
	}
}
