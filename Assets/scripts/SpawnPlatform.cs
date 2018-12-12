using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlatform : MonoBehaviour {

    public int maxPlatforms;
    public GameObject platform;
    public float maxHorizontal, minHorizontal;
    public float maxVertical, minVertical;

    private Vector2 originPosition;
	// Use this for initialization
	void Start ()
    {
        originPosition = transform.position;
        Spawn();
	}

    void Spawn()
    {
        int i;
        for (i = 0; i < maxPlatforms; i++)
        {
            Vector2 randomPosition = originPosition + new Vector2(Random.Range(minHorizontal, maxHorizontal), Random.Range(minVertical, maxVertical));
            Instantiate(platform, randomPosition, Quaternion.identity);
            originPosition = randomPosition;
        }
    }

	
}
