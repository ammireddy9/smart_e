using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class target1 : MonoBehaviour {
	public Canvas levelcomplete;
	public AudioClip tar;
	GameObject ballsprite;
	int count;
	static public int i=1;
	string name;
	// Use this for initialization
	void Start () {
		levelcomplete = levelcomplete.GetComponent<Canvas> ();
		levelcomplete.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnCollisionEnter2D (Collision2D collision) {
		if (collision.gameObject.tag == "Damager") {
			Destroy (collision.gameObject);
			show();
		}
		if (collision.collider.tag != "Damager")
			return;
	}
	public void show()
	{
		AudioSource.PlayClipAtPoint (tar, transform.position);
		levelcomplete.enabled = true;
	}
	public void nextlevel()
	{
		
		projectile.y = 4;
		i++;
		value ();
		name = i.ToString ();
		Application.LoadLevel (name);
		ballsprite = GameObject.Find ("BallSprite");
		projectile prjc = ballsprite.GetComponent<projectile>();
	}
	public void retrylevel()
	{
		projectile.y = 4;
		Application.LoadLevel (Application.loadedLevel);
		ballsprite = GameObject.Find ("BallSprite");
		projectile prjc = ballsprite.GetComponent<projectile> ();
	}
	public static void value()
	{
		PlayerPrefs.SetInt ("key", i);
	}
}