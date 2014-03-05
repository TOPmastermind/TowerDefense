using UnityEngine;
using System.Collections;

public class GuiTextureControl : MonoBehaviour {

	private GUITexture gui;
	public GameObject tower;			// Tower generation
	public bool flag = false;

	// Use this for initialization
	void Start () 
	{
		gui = gameObject.GetComponent<GUITexture>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		/*
		if (Input.touchCount > 0)
		{
			for(int i = 0; i < Input.touchCount; i++)
			{
				Touch touch = Input.GetTouch(i);
				if (touch.phase == TouchPhase.Began && gui.HitTest(touch.position))
				{
					break;
				}
			}
		}
		**/

		if (Input.GetMouseButtonDown(0) && gui.HitTest(Input.mousePosition))
		{
			if (!flag)
			{
				Debug.Log("Touch");
				Instantiate(tower, transform.position, transform.rotation);
				flag = true;
			}
		}
	}

	void FixedUpdate()
	{
		flag = false;
	}
}
