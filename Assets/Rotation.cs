using UnityEngine;

public class Rotation : MonoBehaviour
{  
    Quaternion[] orientations = new Quaternion[] {
        Quaternion.LookRotation(Vector3.forward, Vector3.right),     //Avant/droit
        Quaternion.LookRotation(Vector3.forward, -Vector3.right),    //Avant/gauche
        Quaternion.LookRotation(Vector3.forward, Vector3.up),        //Avant/Haut
        Quaternion.LookRotation(Vector3.forward, -Vector3.up),       //Avant/Bas
        Quaternion.LookRotation(-Vector3.forward, Vector3.right),    //Arriere/Droit
        Quaternion.LookRotation(-Vector3.forward, -Vector3.right),   //Arriere/Gauche
        Quaternion.LookRotation(-Vector3.forward, Vector3.up),       //Arriere/Haut
        Quaternion.LookRotation(-Vector3.forward, -Vector3.up),      //Arriere/Bas
        Quaternion.LookRotation(Vector3.right, Vector3.forward),     //Droit/Avant
        Quaternion.LookRotation(Vector3.right, -Vector3.forward),    //Droit/Arriere
        Quaternion.LookRotation(Vector3.right, Vector3.up),          //Droit/Haut
        Quaternion.LookRotation(Vector3.right, -Vector3.up),         //Droit/Bas
        Quaternion.LookRotation(-Vector3.right, Vector3.forward),    //Gauche/Avant
        Quaternion.LookRotation(-Vector3.right, -Vector3.forward),   //Gauche/Arriere
        Quaternion.LookRotation(-Vector3.right, Vector3.up),         //Gauche/Haut
        Quaternion.LookRotation(-Vector3.right, -Vector3.up),        //Gauche/Bas
        Quaternion.LookRotation(Vector3.up, Vector3.right),          //Haut/Droit
        Quaternion.LookRotation(Vector3.up, -Vector3.right),         //Haut/Gauche
        Quaternion.LookRotation(Vector3.up, Vector3.forward),        //Haut/Avant
        Quaternion.LookRotation(Vector3.up, -Vector3.forward),       //Haut/Arriere
        Quaternion.LookRotation(-Vector3.up, Vector3.right),         //Bas/Droit
        Quaternion.LookRotation(-Vector3.up, -Vector3.right),        //Bas/Gauche
        Quaternion.LookRotation(-Vector3.up, Vector3.forward),       //Bas/Avant
        Quaternion.LookRotation(-Vector3.up, -Vector3.forward)       //Bas/Arriere
    };

    int[,] neighborIndices;
    int orientationIndex;
    Quaternion orientation1;
    Quaternion orientation2;
    public static bool rotating;
    float rotationTimer;
    const float rotationTime = .4f;


    /// <summary>
    /// Initialise la logique de rotation
    /// du DiskRotation
    /// </summary>
    public void InitializeCubeRotation()
    {       
        neighborIndices = new int[24, 6];

        Quaternion[] directions = new Quaternion[] {Quaternion.AngleAxis(-90, Vector3.up),
                                                    Quaternion.AngleAxis(90, Vector3.up),
                                                    Quaternion.AngleAxis(-90, Vector3.right),
                                                    Quaternion.AngleAxis(90, Vector3.right),
                                                    Quaternion.AngleAxis(-90,Vector3.forward),
                                                    Quaternion.AngleAxis(90,Vector3.forward)                                                  
        };

        for (int i = 0; i < 24; ++i)
        {
            for (int j = 0; j < 6; ++j)
            {
                var currentOrientation =
                    directions[j] * orientations[i];
                float maxDot = 0f;
                int neighborIndex = 0;
                for (int k = 0; k < 24; ++k)
                {
                    float dot = Mathf.Abs(Quaternion.Dot(currentOrientation, orientations[k]));
                    if (dot > maxDot)
                    {
                        maxDot = dot;
                        neighborIndex = k;
                    }
                }
                neighborIndices[i, j] = neighborIndex;
            }
        }

       transform.rotation = orientations[orientationIndex];
    }


    /// <summary>
    /// Check et rotate le disk suivant le pad sélectionné
    /// </summary>
    /// <param name="listPads"></param>
    public void UpdateRotationDisk(int rot)
    {
        if (rotating)
        {
            rotationTimer += Time.deltaTime;
           
            if (rotationTimer >= rotationTime)
            {
                transform.rotation = orientation2;
                rotating = false;               
            }
            else
            {
                float t = rotationTimer / rotationTime;
                transform.rotation = Quaternion.Slerp(orientation1, orientation2, t);              
            }
        }
        else
        {
            if (rot != -1)
            {
                orientationIndex = neighborIndices[orientationIndex, rot];
                orientation1 = transform.rotation;
                orientation2 = orientations[orientationIndex];

                rotationTimer = 0f;
                rotating = true;
            }
        }                            
    }    
}
