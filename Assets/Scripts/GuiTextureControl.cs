using UnityEngine;
using System.Collections;

public class GuiTextureControl : MonoBehaviour {

	public Texture2D normal;
	public Texture2D press;

	public GameObject tower;						// Tower generation
	public bool flag = false;
	public bool canPlaceTower = false;

	// Use this for initialization
	void Start () 
	{
		guiTexture.texture = normal;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetMouseButtonDown(0) && guiTexture.HitTest(Input.mousePosition))
		{
			guiTexture.texture = press;
			if (!flag)
			{
				// Debug.Log("Touch");
				// Instantiate(tower, transform.position, transform.rotation);
				flag = true;
				canPlaceTower = true;
			}
		}


	}

	void FixedUpdate()
	{
		flag = false;
		if (Input.GetMouseButtonDown(0))
		{
			Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			if (canPlaceTower)
			{
				Instantiate(tower, new Vector3(mousePosition.x, mousePosition.y, -3), transform.rotation);
				canPlaceTower = false;
				guiTexture.texture = normal;
			}
		}
	}
}
