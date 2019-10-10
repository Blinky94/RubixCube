using UnityEngine;
using System.Collections;

public class IdentifyCube : MonoBehaviour
{
    public  GameObject currentCube;

    void Start()
    {
        currentCube = null;
    }
   
    void OnCollisionEnter(Collision _currentCube)
    {
        currentCube = _currentCube.gameObject;
    }
}
