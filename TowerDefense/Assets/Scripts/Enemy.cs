using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoveType;

public class Enemy : MonoBehaviour {

	public int time;

	public float speed;

	public int energy;

	public int life;
    public bool isLived = true;


	public MoveType.MoveType _type;

	public GameObject _roads;
    private Transform nextPosition;
    private Transform[] nextPositions;
    private int positionIndex;
    // Use this for initialization
    void Start () {
        nextPositions = _roads.GetComponentsInChildrenWithoutSelf<Transform>();
        positionIndex = 0;
        transform.position = nextPositions[positionIndex].transform.position;
        positionIndex += 1;
        nextPosition = nextPositions[positionIndex];
	}

	// Update is called once per frame
	void Update () {
        Move();
	}

    void Move()
    {
        if (nextPositions.Length <= positionIndex) return;
        transform.position = Vector3.MoveTowards(transform.position, nextPosition.position, speed);
        if(Vector3.Distance(transform.position,nextPosition.position) <= 0.3f)
        {
            positionIndex += 1;
            if(nextPositions.Length <= positionIndex)
            {
                GameManager.Instance.GameOver();
                isLived = false;
                Destroy(gameObject);
                return;
            }
            nextPosition = nextPositions[positionIndex];
        }
    }
}
