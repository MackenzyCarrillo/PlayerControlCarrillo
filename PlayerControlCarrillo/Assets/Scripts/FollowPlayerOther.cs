using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerOther : MonoBehaviour
{

    public GameObject player;
    private Vector3 offset = new Vector3(0, 3, 2);
    private Camera myCamera;
    
    
    // Start is called before the first frame update
    void Start()
    {
        myCamera = GetComponent<Camera>();
    }


    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            myCamera.enabled = !myCamera.enabled;
        }
            
    }



    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
