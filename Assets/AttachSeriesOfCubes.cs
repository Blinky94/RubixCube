using UnityEngine;
using System;
using System.Collections.Generic;

public static class AttachSeriesOfCubes
{
   /// <summary>
        /// InitializeAttachmentObject
   /// </summary>
    public static void InitializeAttachmentObject()
    {
        IdentObj.IdentifySelection();
    }


    /// <summary>
    /// ToSelection
    /// </summary>
    /// <param name="listObjIn"></param>
    /// <param name="listObjOut"></param>
    public static void ToSelection(List<GameObject> listObjIn,List<GameObject> listObjOut)
    {       
        foreach(GameObject obj in listObjIn)
            obj.gameObject.transform.parent = IdentObj.InSelection.transform;


        foreach(GameObject obj in listObjOut)
            obj.gameObject.transform.parent = IdentObj.OutSelection.transform;
    }
}
