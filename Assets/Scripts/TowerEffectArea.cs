using UnityEngine;
using System.Collections;

public class TowerEffectArea : MonoBehaviour {

	// Config
	public GameObject areaImage;
	public Vector2 positionOffset;
	public float areaRadius;
	private GameObject effectArea;

	// Use this for initialization
	void Start () 
	{
		effectArea = Instantiate(areaImage, transform.position + new Vector3(positionOffset.x, positionOffset.y, 1),
		                         transform.rotation) as GameObject;
		effectArea.transform.localScale = new Vector3(areaRadius * 2f, areaRadius * 2f, 0);
		effectArea.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (gameObject.GetComponent<DragTower>().isDragging)
		{
			effectArea.SetActive(true);
			effectArea.transform.position = transform.position + new Vector3(positionOffset.x, positionOffset.y, 1);
		}
		else
		{
			effectArea.SetActive(false);
		}
	}
}
