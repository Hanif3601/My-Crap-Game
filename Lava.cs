using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    [SerializeField] GameObject ThingToFolllow;
    void Update()
    {
        transform.position = ThingToFolllow.transform.position + new Vector3(0, 0, -10);
    }
}
