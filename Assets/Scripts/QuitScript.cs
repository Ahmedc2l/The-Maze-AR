using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitScript : MonoBehaviour {
	public void Quit(){
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPaused = true;
		#else
		Application.Quit();
		#endif
	}
}