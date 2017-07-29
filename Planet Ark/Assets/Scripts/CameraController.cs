using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject followTarget;
    private Vector3 targetPos;
    public float moveSpeed;
    Camera mycam;

    private static bool CameraExists;

    // Use this for initialization
    void Start () {
        mycam = GetComponent<Camera>();
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
	void FixedUpdate () {
        targetPos = new Vector3(followTarget.transform.position.x, followTarget.transform.position.y, -10); //transform.position.z
        transform.position = Vector3.Lerp(transform.position, targetPos, moveSpeed * Time.deltaTime);
         } //void Update
}
