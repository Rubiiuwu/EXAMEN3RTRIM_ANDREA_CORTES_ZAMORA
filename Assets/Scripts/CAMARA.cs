using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAMARA : MonoBehaviour
{

    public Transform target;
    public Vector3 offset;
    public Vector3 limitX;
	public Vector3 limitY;

    // Start is called before the first frame update
    void Start()
    {
    target = GameObject.Find ("Mario").GetComponent<Transform>();
    }


    // Update is called once per frame
    void Update()
    {

	Vector3 desiredPosition =  target.position + offset;
	float clampX = Mathf.Clamp(desiredPosition.x, limitX.x, limitX.y);
    float clampY = Mathf.Clamp(desiredPosition.y, limitY.x, limitY.y);
    Vector3 clampedPosition = new Vector3(clampX, clampY, desiredPosition.z);
    }



    }
