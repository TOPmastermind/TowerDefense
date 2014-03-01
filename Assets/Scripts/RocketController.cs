using UnityEngine;
using System.Collections;

public class RocketController : MonoBehaviour {

    // Config
    public GameObject target;
    public float speed;
    private TowerGunController controller;


	// Use this for initialization
	void Start () {
        // Destroy(gameObject, 3);
	}

    void Awake() 
    {
        // controller = transform.root.GetComponent<TowerController>;
        // controller = transform.root.gameObject.GetComponent<TowerController>;
        // target = GameObject.FindGameObjectWithTag("Enemy");
    }
	
	// Update is called once per frame
	void Update () 
    {
        if (target != null)
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, (speed)*Time.deltaTime);
        else
            Destroy(gameObject);
	}

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.tag == "Enemy")
			Destroy(gameObject);
	}
}
