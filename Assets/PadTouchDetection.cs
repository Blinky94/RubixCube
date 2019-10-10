using UnityEngine;

public class PadTouchDetection : MonoBehaviour
{
    public bool IsCollide = false;

    /// <summary>
    /// OnMouseEnter
    /// </summary>
    void OnMouseEnter()
    {
        IsCollide = true;
    }


    /// <summary>
    /// MonMouseExit
    /// </summary>
    void OnMouseExit()
    {
        IsCollide = false;     
    }
}
