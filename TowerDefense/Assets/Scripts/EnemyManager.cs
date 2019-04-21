using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : SingletonMonoBehaviourFast<EnemyManager> {

	public List<Enemy> enemies;
	public List<GameObject> templeteEnemies;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

    public GameObject SpawnEnemy(int id, GameObject road)
    {
        var obj = Instantiate(templeteEnemies[id]);
        obj.transform.parent = gameObject.transform;
        var enemy = obj.GetComponent<Enemy>();
        enemy._roads = road;
        enemies.Add(enemy);
        return obj;
    }
}
