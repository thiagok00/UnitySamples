using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSceneController : MonoBehaviour {

	public Player player;
	public Camera gameCamera;
	public GameObject[] blockPrefabs;

	void Start () {
		Instantiate (blockPrefabs[0]);
	}

	void Update () {
		if (player != null)
			gameCamera.transform.position = new Vector2(player.transform.position.x, gameCamera.transform.position.y);
	}
}
