using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class play : MonoBehaviour {

	string name;
	public Button cont;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void plays()
	{
		if (target1.i == 0) {
			target1.i = 1;
			Application.LoadLevel("play");
		}
	}
	public void continues()
	{
		int k=target1.i;
		name=k.ToString();
		Application.LoadLevel(name);
	}
}
