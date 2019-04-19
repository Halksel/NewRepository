using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Road = System.Collections.Generic.List<UnityEngine.GameObject>;

public class GameManager : MonoBehaviour {
	public struct EnemySpwanInfo
	{
			public int roadId;
			public int time;
			public int enemyId;
	}
	public Road road;
	public List<Road> roads;

	public int time;
	public List<EnemySpwanInfo> enemySpawninfo;

	[SerializeField]
	private TowerManager towerManager;
	[SerializeField]
	private EnemyManager enemyManager;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void GameOver(){

	}
}
