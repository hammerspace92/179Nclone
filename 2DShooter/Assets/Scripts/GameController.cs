using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public GameObject hazard;
	public Vector3 spawnValues;
	public int hazardCount;
	public float spawnWait;
	public float startWait;

	void Start()
	{
		StartCoroutine (SpawnWaves ());
	}

	IEnumerator SpawnWaves ()
	{
			yield return new WaitForSeconds (startWait);
			while (true) {
					for (int i = 0; i<hazardCount; i++) {
							Vector3 spawnPosition = new Vector3 (spawnValues.x, Random.Range (-6, 6), spawnValues.z);
							Quaternion spawnRotation = Quaternion.identity;
							Instantiate (hazard, spawnPosition, spawnRotation);
							yield return new WaitForSeconds (spawnWait);
					}

			}
	}
}
