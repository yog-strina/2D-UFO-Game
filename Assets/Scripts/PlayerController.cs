using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

	public float speed;
	public Text scoreText;
	public Text winText;

	private Rigidbody2D rb2d;
	private int score;

	void Start()
	{
		rb2d = GetComponent<Rigidbody2D>();
		score = 0;
		winText.text = "";
		SetScoreText();
	}

	void FixedUpdate() // For physics code
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		Vector2 movement = new Vector2(moveHorizontal, moveVertical);
		
		rb2d.AddForce(movement*speed);
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("PickUp"))
		{
			other.gameObject.SetActive(false);
			score++;
			SetScoreText();
		}
	}

	void SetScoreText()
	{
		scoreText.text = "Score: " + score.ToString();
		if (score >= 12)
		{
			winText.text = "You win !";
		}
	}
}
