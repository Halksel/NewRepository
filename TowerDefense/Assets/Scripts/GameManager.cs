using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : SingletonMonoBehaviourFast<GameManager> {
	public class EnemySpwanInfo
	{
        public int roadId;
        public int time;
        public int enemyId;

        public EnemySpwanInfo(int v1, int i, int v2)
        {
            this.roadId = v1;
            this.time = i;
            this.enemyId = v2;
        }
    }
	private GameObject road;
	public List<GameObject> roads;

	public int time = 0;
	public EnemySpwanInfo[] enemySpawnInfo;



    public GameObject Road
    {
        get
        {
            return road;
        }

        set
        {
            road = value;
        }
    }

    void Awake()
    {
        enemySpawnInfo = new EnemySpwanInfo[5];
        for(int i = 0; i < 5; ++i)
        {
            enemySpawnInfo[i] = new EnemySpwanInfo( 0,i,0);
        }
    }
    // Use this for initialization
    void Start () {
        StartCoroutine("TimeCount");
	}


    // Update is called once per frame
    void Update () {

	}

	public void GameOver(){
        Debug.Log("GameOver");
	}

    IEnumerator TimeCount()
    {
        int enemyIndex = 0;
        while (true)
        {
            if(enemyIndex < enemySpawnInfo.Length && enemySpawnInfo[enemyIndex].time == time)
            {
                var enemyInfo = enemySpawnInfo[enemyIndex];
                EnemyManager.Instance.SpawnEnemy(enemyInfo.enemyId, roads[enemyInfo.roadId]);
                enemyIndex += 1;
            }
            else
            {
                yield break;
            }
            time += 1;
            yield return new WaitForSeconds(1.0f);
        }
    }
}
