using UnityEngine;
using System.Collections;

public class ButtonScript : MonoBehaviour {

	// Config
	public Texture2D pause;
	public Texture2D play;
	public bool isPause = false;

	// Use this for initialization
	void Start () 
	{
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (isPause)
		{
			Time.timeScale = 0.0f;
		}
		else
			Time.timeScale = 1.0f;
	}

	void OnMouseExit()
	{
		if (isPause)
			guiTexture.texture = play;
		else
			guiTexture.texture = pause;
	}

	void OnMouseDown()
	{
		if (isPause)
			guiTexture.texture = pause;
		else
			guiTexture.texture = play;
		isPause = !isPause;
	}
}
