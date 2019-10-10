using UnityEngine;
using System.Collections;

public class CameraLookAt : MonoBehaviour 
{
    public Transform target;

    void Start()
    {
        target = GameObject.Find("InSelection").transform;
    }

    void Update()
    {
        transform.LookAt(target);
    }
}
