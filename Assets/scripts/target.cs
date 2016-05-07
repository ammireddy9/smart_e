using UnityEngine;
using System.Collections;

public class target : MonoBehaviour {

	public int hitPoints = 2;					
	public Sprite damagedSprite;				
	public float damageImpactSpeed;				
	//public Canvas levelcompletemanager;
	private int currentHitPoints;				
	private float damageImpactSpeedSqr;			
	private SpriteRenderer spriteRenderer;		

	void Start () {
		spriteRenderer = GetComponent <SpriteRenderer> ();

		currentHitPoints = hitPoints;

		damageImpactSpeedSqr = damageImpactSpeed * damageImpactSpeed;
		//levelcompletemanager = levelcompletemanager.GetComponent<Canvas> ();
		//levelcompletemanager.enabled=false
	}

	void OnCollisionEnter2D (Collision2D collision) {
		if(collision.gameObject.tag=="Damager")
		{
			Destroy(collision.gameObject);
			Application.LoadLevel("main");
			//levelcompletemanager.enabled=true;
		}
		if (collision.collider.tag != "Damager")
			return;

		if (collision.relativeVelocity.sqrMagnitude < damageImpactSpeedSqr)
			return;
		spriteRenderer.sprite = damagedSprite;
		currentHitPoints--;

		if(currentHitPoints <= 0)
			Kill ();
	}

	void Kill () {
		spriteRenderer.enabled = false;
		GetComponent<Collider2D>().enabled = false;
		GetComponent<Rigidbody2D>().isKinematic = true;
		GetComponent<ParticleSystem>().Play();
	}
}
