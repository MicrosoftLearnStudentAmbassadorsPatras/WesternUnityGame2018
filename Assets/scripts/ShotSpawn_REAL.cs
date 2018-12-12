using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotSpawn_REAL : MonoBehaviour {

    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;
    private float nextFire = 0f;

	// Use this for initialization
	void Start () {
		
	}

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.transform.rotation);
        }
    }
}
