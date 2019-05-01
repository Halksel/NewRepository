using UnityEngine;
using System.Collections;

public class ShaderControl : MonoBehaviour {
	void Start () {
		GetComponent<Renderer> ().material.SetColor ("_BaseColor", Color.black);
	}
}