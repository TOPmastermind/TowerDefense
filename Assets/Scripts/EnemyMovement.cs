using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

	public float runSpeed = 21f;
	public Vector3 velocity;
	private Animator _animator;
	public string moveDirection;					// right, left, up, down
    public int health = 3;

	// Use this for initialization
	void Start () 
	{
		_animator = GetComponent<Animator>();
	}
	
    void OnTriggerEnter2D (Collider2D other)
    {
        // If the enemy hit the redirection point
        if (other.tag == "Redirect")
        {
            moveDirection = other.gameObject.GetComponent<RedirectController>().direction;
        } 
        else if (other.tag == "FinishPoint")
        {
            Destroy(gameObject);
        }
        else if (other.tag == "TowerBullet")
        {
            health--;
            if (health <= 0)
            {
                Destroy(gameObject);
                Destroy(other.gameObject);
            }
        }
    }

	// Update is called once per frame
	void Update () 
	{
		if (moveDirection == "right") 
		{
			transform.position += new Vector3(runSpeed, 0, 0);
			_animator.Play( Animator.StringToHash( "Run up" ));
		}
		else if (moveDirection == "left") 
		{
			transform.position -= new Vector3(runSpeed, 0, 0);
			_animator.Play( Animator.StringToHash( "Run up" ));
		}
		else if (moveDirection == "up") 
		{
			transform.position += new Vector3(0, runSpeed, 0);
			_animator.Play( Animator.StringToHash( "Run up" ));
		}
		else
		{
			transform.position -= new Vector3(0, runSpeed, 0);
			_animator.Play( Animator.StringToHash( "Run up" ));
		}
	}
}
