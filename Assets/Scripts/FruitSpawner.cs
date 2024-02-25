using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    public GameObject[] fruits;
    private Camera mainCamera;
    private bool isTouching;

    private void Start()
    {
        mainCamera = Camera.main;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isTouching = true;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            isTouching = false;
        }

        if (isTouching)
        {
            var mousePosition = Input.mousePosition;

            var worldPosition = mainCamera.ScreenToWorldPoint(mousePosition);
            transform.position = new Vector3(worldPosition.x, 4, 0);

        }
        if (Input.GetMouseButtonUp(0))
        {
            SpawnFruit(transform.position, Random.Range(0, fruits.Length));
        }
    }

    public void SpawnFruit(Vector2 position, int FruitIndex)
    {
        if (FruitIndex <= fruits.Length)
        {
            var fruit = Instantiate(fruits[FruitIndex], position, Quaternion.identity);
        }
        else return;
    }
}
