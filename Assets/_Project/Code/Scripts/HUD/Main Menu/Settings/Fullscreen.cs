using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fullscreen : MonoBehaviour
{
	public void Change()
	{
		Screen.fullScreen = !Screen.fullScreen;
		Debug.Log("Changed Screen Mode");
	}
}
