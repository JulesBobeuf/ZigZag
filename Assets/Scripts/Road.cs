using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour {

    public GameObject roadPrefab;
    public GameObject roadPart;
    public float offset = 0.7f;
	public Vector3 lastPos;


	public void StartBuilding()
	{
		InvokeRepeating("CreateNewRoadPart", 1f, .5f);
	}
	
	public void CreateNewRoadPart()
	{
		Vector3 pos = Vector3.zero;

		float chance = Random.Range(0, 100);

		float chanceCristal = Random.Range(0, 5);

		GameObject g;


        if (chance > 50)
		{
            pos = new Vector3(lastPos.x + offset, lastPos.y, lastPos.z + offset);
		}
		else
		{
            pos = new Vector3(lastPos.x - offset, lastPos.y, lastPos.z + offset);
        }
		if (chanceCristal == 3)
		{
            g = Instantiate(roadPrefab, pos, Quaternion.Euler(0, 45, 0));
        }
		else
		{
            g = Instantiate(roadPart, pos, Quaternion.Euler(0, 45, 0));
        }
		lastPos = g.transform.position;

	}
}
