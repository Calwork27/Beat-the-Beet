using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBeetroots : MonoBehaviour
{
    public float lastSpawn;
    public float spawnDelay;
    public GameObject beetrootLeft;
    public GameObject beetrootRight;
    public GameObject beetrootUp;
    public GameObject beetrootDown;
    private int beetSpawnPos;
    private int tempNum = 0;

    public float beatTempo;
    // Start is called before the first frame update
    void Start()
    {
        beatTempo = beatTempo / 30;

    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time > lastSpawn + spawnDelay)
        {
            tempNum++;
            beetSpawnPos = Random.Range(1, 5);
            //Debug.Log(beetSpawnPos);
            {
                if (beetSpawnPos == 1)
                {
                    Instantiate(beetrootUp, new Vector3(0, 9, 0), Quaternion.identity);
                }
                if (beetSpawnPos == 2)
                {
                    Instantiate(beetrootDown, new Vector3(0, -9, 0), Quaternion.identity);
                }
                if (beetSpawnPos == 3)
                {
                    Instantiate(beetrootRight, new Vector3(9, 0, 0), Quaternion.identity);
                }
                if (beetSpawnPos == 4)
                {
                    Instantiate(beetrootLeft, new Vector3(-9, 0, 0), Quaternion.identity);
                }
                lastSpawn = Time.time;
                //Debug.Log(Time.time);
                //Debug.Log(lastSpawn);
            } 
        }
    }
}
