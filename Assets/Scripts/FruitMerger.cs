using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitMerger : MonoBehaviour
{
    FruitSpawner spawner;

    private void Awake()
    {
        var spawnerObj = GameObject.FindGameObjectWithTag("Spawner");
        spawner = spawnerObj.GetComponent<FruitSpawner>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameObject.tag == collision.gameObject.tag)
        {
            spawner.SpawnFruit(collision.transform.position, int.Parse(gameObject.tag) + 1);
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
