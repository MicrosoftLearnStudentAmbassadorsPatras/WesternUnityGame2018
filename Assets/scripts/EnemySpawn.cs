using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {

    public Transform[] enemySpawns;
    public GameObject enemy;

	// Use this for initialization
	void Start ()
    {
        Spawn();
		
	}

    private void Spawn()
    {
        int i = 0;
        bool flag = false;
        while(i<enemySpawns.Length && !flag)
        {
            int enemySpawn = Random.Range(0, 2);
            if (enemySpawn == 1)
            {
                Instantiate(enemy, enemySpawns[i].position, Quaternion.identity);
                flag = true;
            }
            i++;
        }
    }
}
