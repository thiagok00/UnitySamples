using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class GameSceneController : MonoBehaviour {

	public Player player;
	public Camera gameCamera;
	public GameObject[] blockPrefabs;
	public Text scoreText;

	private float  gamePointer;
	private float safeSpawningArea = 25;

	void Start () {
		gamePointer = -19;
	}

	void Update ()
	{
		if (player != null) {
			gameCamera.transform.position = new Vector2 (player.transform.position.x, gameCamera.transform.position.y);

			while (player != null && gamePointer < player.transform.position.x + safeSpawningArea) {

				int blockIndex = Random.Range (0, blockPrefabs.Length);
				GameObject blockObject = Instantiate (blockPrefabs [blockIndex]);
				blockObject.transform.SetParent (this.transform);
				Block block = blockObject.GetComponent<Block> ();
				blockObject.transform.position = new Vector3 (gamePointer + block.size / 2, -3.21f, 11);
				gamePointer += block.size;
			}
			float score;

			if (player.transform.position.x > 0)
				score = player.transform.position.x;
			else
				score = 0f;

			scoreText.text = "Score: " + Mathf.Floor (score);
		}
	}




}
