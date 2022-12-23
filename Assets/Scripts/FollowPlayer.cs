using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private Vector3 offset = new Vector3(0, 8, -7);
    [SerializeField] private Vector3 newOffset = new Vector3(0, 2, 2);

    // Update is called once per frame
    void LateUpdate()
    {
        //attach camera to player's position + offset camera
        transform.position = player.transform.position + offset;
        if (Input.GetKey(KeyCode.Mouse0))
        {
            transform.position = player.transform.position + newOffset;
        }
    }
}
