using UnityEngine;
//using UnityEngine.UI;
using System.Collections;

public class levelcomplete : MonoBehaviour {
	static public int i;
	public void retryLevel(){
		Application.LoadLevel (Application.loadedLevel);
	}
	public void nextLevel()
	{
		i++;
		string z = i.ToString ();
		Application.LoadLevel (z);
	}
}
