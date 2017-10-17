using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed = 2f;
    private bool release;

    Vector3 target;

	void Update()
    {
        if (!release)
        {
            target = Input.mousePosition;
            target = Camera.main.ScreenToWorldPoint(target);
            target.y = transform.position.y;
            target.z = Mathf.Clamp(transform.position.z, 0, 0);
            transform.position = Vector3.Lerp(transform.position, target, speed = Time.deltaTime);

            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                release = true;
                GetComponent<Rigidbody2D>().gravityScale = 1;
            }
        }

	}
}
