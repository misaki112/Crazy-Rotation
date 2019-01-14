using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour {


    #region Singleton
        public static Spawner instance;

        private void Awake()
        {
            instance = this;        
        }
    #endregion

    public float spawnRate = 1f;
    public int score = 0;
    public bool stop = false;

    public GameObject rectanglePrefab;
    private float nextTimeToSpawn = 0f;

    // Update is called once per frame
    void Update () {
	    if (Time.time >= nextTimeToSpawn && !stop)
        {
            GameObject rec = Instantiate(rectanglePrefab, Vector3.zero, Quaternion.identity);
            nextTimeToSpawn = Time.time + 1 / spawnRate;
        }
	}

}
