using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelController : MonoBehaviour
{
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{
			Debug.Log("Got sum Sushi yum yum...");
            MyGameManager.instance.AddScore(10);
            Destroy(gameObject);
		}
	}
}
