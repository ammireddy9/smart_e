using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class menumanager : MonoBehaviour {

	public Canvas ExitManager;
	string name;
	// Use this for initialization
	void Start () {
		ExitManager = ExitManager.GetComponent<Canvas> ();
		ExitManager.enabled = false;
		Application.targetFrameRate = 60;
	}
	void update()
	{
	}

	public void exit()
	{
		ExitManager.enabled = true;
	}
	public void yes()
	{
		Application.Quit ();
	}
	public void no()
	{
		ExitManager.enabled = false;
	}
	public void play()
	{
		if (target1.i == 0) {
			target1.i = 1;
			Application.LoadLevel ("play");
		} else
			Application.LoadLevel ("play");
	}
	public void levels()
	{
		Application.LoadLevel ("levels");
	}
	public void l1()
	{
		target1.i = 1;
		target1.value ();
		Application.LoadLevel ("1");
	}
	public void l2()
	{
		target1.i = 2;
		target1.value ();
		Application.LoadLevel ("2");
	}
	public void l3()
	{
		target1.i = 3;
		target1.value ();
		Application.LoadLevel ("3");
	}
	public void l4()
	{
		target1.i = 4;
		target1.value ();
		Application.LoadLevel ("4");
	}
	public void l5()
	{
		target1.i = 5;
		target1.value ();
		Application.LoadLevel ("5");
	}
	public void l6()
	{
		target1.i = 6;
		target1.value ();
		Application.LoadLevel ("6");
	}
	public void l7()
	{
		target1.i = 7;
		target1.value ();
		Application.LoadLevel ("7");
	}
	public void l8()
	{
		target1.i = 8;
		target1.value ();
		Application.LoadLevel ("8");
	}
	public void l9()
	{
		target1.i = 9;
		target1.value ();
		Application.LoadLevel ("9");
	}
	public void l10()
	{
		target1.i = 10;
		target1.value ();
		Application.LoadLevel ("10");
	}
	public void continues()
	{
		int k = PlayerPrefs.GetInt("key");
		name=k.ToString();
		Application.LoadLevel(name);
	}
}
