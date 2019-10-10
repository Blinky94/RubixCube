/*using UnityEngine;

public class DiskRotation : Rotation
{
    int rotation;

    GameObject RotationPadUp, RotationPadLeft,
            RotationPadRight, RotationPadDown,
            RotationPadForward, RotationPadBackward;

    GameObject RotationHorizontalDownRight, RotationHorizontalDownLeft;
    GameObject RotationHorizontalMiddleRight, RotationHorizontalMiddleLeft;
    GameObject RotationHorizontalUpLeft, RotationHorizontalUpRight;
    GameObject RotationVerticalLeftDown, RotationVerticalLeftUp;
    GameObject RotationVerticalMiddleDown, RotationVerticalMiddleUp;
    GameObject RotationVerticalRightUp, RotationVerticalRightDown;

     GameObject cube;
     GameObject diskAxeXUp, diskAxeXMiddle, diskAxeXDown, diskAxeYLeft, diskAxeYMiddle, diskAxeYRight;

    /// <summary>
    /// 
    /// </summary>
	void Start ()
    {
        //Initialise les "Disk" de rattachement des series pour les directions
        cube = GameObject.Find("RotationCube");
        diskAxeXUp = GameObject.Find("RotationDiskAxeXUp");
        diskAxeXMiddle = GameObject.Find("RotationDiskAxeXMiddle");
        diskAxeXDown = GameObject.Find("RotationDiskAxeXDown");
        diskAxeYLeft = GameObject.Find("RotationDiskAxeYLeft");
        diskAxeYMiddle = GameObject.Find("RotationDiskAxeYMiddle");
        diskAxeYRight = GameObject.Find("RotationDiskAxeYRight");

        //Initialise les "Pad" pour les selections de directions
        RotationPadUp = GameObject.Find("RotationPadUp");
        RotationPadLeft = GameObject.Find("RotationPadLeft");
        RotationPadRight = GameObject.Find("RotationPadRight");
        RotationPadDown = GameObject.Find("RotationPadDown");
        RotationPadForward = GameObject.Find("RotationPadForward");
        RotationPadBackward = GameObject.Find("RotationPadBackward");


        RotationHorizontalDownRight = GameObject.Find("RotationHorizontalDownRight");
        RotationHorizontalDownLeft = GameObject.Find("RotationHorizontalDownLeft");

        RotationHorizontalMiddleLeft = GameObject.Find("RotationHorizontalMiddleLeft");
        RotationHorizontalMiddleRight = GameObject.Find("RotationHorizontalMiddleRight");
        
        RotationHorizontalUpLeft = GameObject.Find("RotationHorizontalUpLeft");
        RotationHorizontalUpRight = GameObject.Find("RotationHorizontalUpRight");

        RotationVerticalLeftDown = GameObject.Find("RotationVerticalLeftDown");
        RotationVerticalLeftUp = GameObject.Find("RotationVerticalLeftUp");

        RotationVerticalMiddleDown = GameObject.Find("RotationVerticalMiddleDown");
        RotationVerticalMiddleUp = GameObject.Find("RotationVerticalMiddleUp");

        RotationVerticalRightUp = GameObject.Find("RotationVerticalRightUp");
        RotationVerticalRightDown = GameObject.Find("RotationVerticalRightDown");
    
        Intialize(); 
        rotation = -1;   
	}  

    /// <summary>
    /// 
    /// </summary>
	void Update ()
    {
        //Concerne les rotations du cube dans son ensemble
        if (RotationPadRight.GetComponent<PadTouchDetection>().IsCollide ||
            RotationPadLeft.GetComponent<PadTouchDetection>().IsCollide ||
            RotationPadDown.GetComponent<PadTouchDetection>().IsCollide ||
            RotationPadUp.GetComponent<PadTouchDetection>().IsCollide ||
            RotationPadForward.GetComponent<PadTouchDetection>().IsCollide ||
            RotationPadBackward.GetComponent<PadTouchDetection>().IsCollide)      
        {

            if (RotationPadRight.GetComponent<PadTouchDetection>().IsCollide)
                rotation = 0;
            else if (RotationPadLeft.GetComponent<PadTouchDetection>().IsCollide)
                rotation = 1;
            else if (RotationPadDown.GetComponent<PadTouchDetection>().IsCollide)
                rotation = 2;
            else if (RotationPadUp.GetComponent<PadTouchDetection>().IsCollide)
                rotation = 3;
            else if (RotationPadForward.GetComponent<PadTouchDetection>().IsCollide)
                rotation = 4;
            else if (RotationPadBackward.GetComponent<PadTouchDetection>().IsCollide)
                rotation = 5;
        }
        else if (RotationHorizontalDownRight.GetComponent<PadTouchDetection>().IsCollide ||
                RotationHorizontalDownLeft.GetComponent<PadTouchDetection>().IsCollide ||
                RotationHorizontalMiddleLeft.GetComponent<PadTouchDetection>().IsCollide ||
                RotationHorizontalMiddleRight.GetComponent<PadTouchDetection>().IsCollide ||
                RotationHorizontalUpLeft.GetComponent<PadTouchDetection>().IsCollide ||
                RotationHorizontalUpRight.GetComponent<PadTouchDetection>().IsCollide ||
                RotationVerticalLeftDown.GetComponent<PadTouchDetection>().IsCollide ||
                RotationVerticalLeftUp.GetComponent<PadTouchDetection>().IsCollide ||
                RotationVerticalMiddleDown.GetComponent<PadTouchDetection>().IsCollide ||
                RotationVerticalMiddleUp.GetComponent<PadTouchDetection>().IsCollide ||
                RotationVerticalRightUp.GetComponent<PadTouchDetection>().IsCollide ||
                RotationVerticalRightDown.GetComponent<PadTouchDetection>().IsCollide)
        {
         
            if (RotationHorizontalDownRight.GetComponent<PadTouchDetection>().IsCollide)
            {
                diskAxeXDown.GetComponent<DiskRotation>().enabled = true;                
                rotation = 0;
            }       
            else if (RotationHorizontalDownLeft.GetComponent<PadTouchDetection>().IsCollide)
            {
                diskAxeXDown.GetComponent<DiskRotation>().enabled = true;                
                rotation = 1;
            }
     
            else if (RotationHorizontalMiddleLeft.GetComponent<PadTouchDetection>().IsCollide)
            {
                diskAxeXMiddle.GetComponent<DiskRotation>().enabled = true;        
                rotation = 1;
            }

            else if (RotationHorizontalMiddleRight.GetComponent<PadTouchDetection>().IsCollide)
            {
                diskAxeXMiddle.GetComponent<DiskRotation>().enabled = true;
                rotation = 0;
            }
      
            else if (RotationHorizontalUpLeft.GetComponent<PadTouchDetection>().IsCollide)
            {         
                diskAxeXUp.GetComponent<DiskRotation>().enabled = true;           
                rotation = 1;
            }        
            else if (RotationHorizontalUpRight.GetComponent<PadTouchDetection>().IsCollide)
            {              
                diskAxeXUp.GetComponent<DiskRotation>().enabled = true;            
                rotation = 0;
            }
        
            else if (RotationVerticalLeftDown.GetComponent<PadTouchDetection>().IsCollide)
            {
                diskAxeYLeft.GetComponent<DiskRotation>().enabled = true;
                rotation = 2;
            }
     
            else if (RotationVerticalLeftUp.GetComponent<PadTouchDetection>().IsCollide)
            {
                diskAxeYLeft.GetComponent<DiskRotation>().enabled = true;
                rotation = 3;
            }
    
            else if (RotationVerticalMiddleDown.GetComponent<PadTouchDetection>().IsCollide)
            {
                diskAxeYMiddle.GetComponent<DiskRotation>().enabled = true;
                rotation = 2;
            }
    
            else if (RotationVerticalMiddleUp.GetComponent<PadTouchDetection>().IsCollide)
            {
                diskAxeYMiddle.GetComponent<DiskRotation>().enabled = true;
                rotation = 3;
            }

            else if (RotationVerticalRightUp.GetComponent<PadTouchDetection>().IsCollide)
            {
                diskAxeYRight.GetComponent<DiskRotation>().enabled = true;          
                rotation = 3;
            }
     
            else if (RotationVerticalRightDown.GetComponent<PadTouchDetection>().IsCollide)
            {
                diskAxeYRight.GetComponent<DiskRotation>().enabled = true;          
                rotation = 2;
            }   
        }
        else
        {
            rotation = -1;
        }

        this.UpdateRotationDisk(rotation);
	}
}
*/