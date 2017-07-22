using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public Transform target;
	public float m_speed = 0.1f;
	Camera mycam;

    private static bool CameraExists;

	// Use this for initialization
	void Start () {

		mycam = GetComponent<Camera> ();
        DontDestroyOnLoad(transform.gameObject);

        if (!CameraExists)
        {
            CameraExists = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

    }
	
	// Update is called once per frame
	void Update () {

		mycam.orthographicSize = (Screen.height / 100f) / 4f;

		if (target) {

			transform.position = Vector3.Lerp (transform.position, target.position, m_speed) + new Vector3 (0, 0, -10);


		}
	}
}
