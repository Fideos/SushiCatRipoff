using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour {

    public GameObject prefab;
    GameObject prefabClone;
    public int intentos;
    bool triggereable;


    void Spawn()
    {
        triggereable = true;
        prefabClone = Instantiate(prefab, new Vector3(0, 4, 0), Quaternion.identity) as GameObject;
        if (intentos == 0)
        {
            Destroy(prefabClone);
            Debug.Log("Game Over");
        }
    }

    void Start()
    {
        Spawn();
    }

    IEnumerator Yielder()
    {
        yield return new WaitForSeconds(2);
        Destroy(prefabClone);
        Spawn();
    }
        
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && triggereable)
        {
            triggereable = false;
            StartCoroutine("Yielder");
            intentos--;
            Debug.Log("Intentos: " + intentos);

        }
    }
}
