using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BULLET : MonoBehaviour

{
    Rigidbody2D rbody;
    public float bulletSpeed = 5;
void Start ()
{
   rbody = GetComponent<Rigidbody2D>();
   rbody.AddForce(transform.right*bulletSpeed,ForceMode2D.Impulse);
}

void OnTriggerEnter2D(Collider2D collider)
 {
	if(collider.gameObject.layer == 6)
	{
	Enemy enemy = collider.gameObject.GetComponent <Enemy> ();
    enemy.Die();
    }
    Destroy(this.gameObject);
  }
}

