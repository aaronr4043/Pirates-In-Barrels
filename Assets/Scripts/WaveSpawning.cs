using UnityEngine;
using System.Collections;

public class WaveSpawning : MonoBehaviour {

    float spawnCD = 5.0f;
    float spawnCDremaining = 0;

    [System.Serializable]
    public class WaveComponent
    {
        public GameObject enemyPrefab;
        public int num;
        [System.NonSerialized]
        public int spawned = 0;
    }

    public WaveComponent[] waveComps;

    void Start()
    {


    }//end start

    void Update()
    {
        
        spawnCDremaining -= Time.deltaTime;
        if (spawnCDremaining < 0)
        {
            bool didSpawn = false;
            spawnCDremaining = spawnCD;
            //go through waves
            foreach(WaveComponent wc in waveComps)
            {
                if (wc.spawned < wc.num)
                {
                    wc.spawned++;
                    Debug.Log("Hello");
                    Instantiate(wc.enemyPrefab, this.transform.position, this.transform.rotation);
                    didSpawn = true;
                    break;
                }
            }
            if (didSpawn == false)
            {
                

            }//end if

        }
    }//end update
    
}
