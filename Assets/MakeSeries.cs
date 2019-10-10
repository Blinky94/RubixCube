using UnityEngine;
using System.Collections.Generic;

public static class MakeSeries
{
    /// <summary>
    /// IntializeSeries
    /// </summary>
    public static void IntializeSeries()
    {
        SetDictionnary.IdentifyCubeCollide();
        SetDictionnary.SetSeriesByCollider();
    }


    /// <summary>
    /// SetRotationSeriesFromPadSelected
    /// </summary>
    /// <param name="_padSelected"></param>
    public static void SetRotationSeriesFromPadSelected(string _padSelected)
    {
        List<GameObject> _listInSelection = new List<GameObject>();
        List<GameObject> _listOutSelection = new List<GameObject>();
        IntializeSeries();

        switch (_padSelected)
        {
            case "RotationPadUp":
                _listInSelection = SetDictionnary.selectAll;
                AttachSeriesOfCubes.ToSelection(_listInSelection, _listOutSelection);
                break;
            case "RotationPadDown":
                _listInSelection = SetDictionnary.selectAll;
                AttachSeriesOfCubes.ToSelection(_listInSelection, _listOutSelection);          
                break;
            case "RotationPadRight": 
                _listInSelection = SetDictionnary.selectAll;
                AttachSeriesOfCubes.ToSelection(_listInSelection, _listOutSelection);       
                break;
            case "RotationPadLeft":
                _listInSelection = SetDictionnary.selectAll;
                AttachSeriesOfCubes.ToSelection(_listInSelection, _listOutSelection);     
                break;
            case "RotationPadForward":
                _listInSelection = SetDictionnary.selectAll;
                AttachSeriesOfCubes.ToSelection(_listInSelection, _listOutSelection);          
                break;
            case "RotationPadForward2":
                _listInSelection = SetDictionnary.selectAll;
                AttachSeriesOfCubes.ToSelection(_listInSelection, _listOutSelection);           
                break;
            case "RotationPadBackward":
                _listInSelection = SetDictionnary.selectAll;
                AttachSeriesOfCubes.ToSelection(_listInSelection, _listOutSelection);          
                break;
            case "RotationPadBackward2":
                _listInSelection = SetDictionnary.selectAll;
                AttachSeriesOfCubes.ToSelection(_listInSelection, _listOutSelection);       
                break; 
            case "Capteur1":
                _listInSelection = SetDictionnary.selectLateralBack;
                _listOutSelection = SetDictionnary.notSelectLateralBack;
                AttachSeriesOfCubes.ToSelection(_listInSelection, _listOutSelection);         
                break;
            case "Capteur2":                             
                _listInSelection = SetDictionnary.selectLateralMiddle;
                _listOutSelection = SetDictionnary.notSelectLateralMiddle;
                AttachSeriesOfCubes.ToSelection(_listInSelection, _listOutSelection);        
                break;
            case "Capteur3":
                _listInSelection = SetDictionnary.selectLateralFront;
                _listOutSelection = SetDictionnary.notSelectLateralFront;
                AttachSeriesOfCubes.ToSelection(_listInSelection, _listOutSelection);      
                break;
            case "Capteur4":                         
                _listInSelection = SetDictionnary.selectVerticalLeft;
                _listOutSelection = SetDictionnary.notSelectVerticalLeft;
                AttachSeriesOfCubes.ToSelection(_listInSelection, _listOutSelection);      
                break;
            case "Capteur5":                      
                _listInSelection = SetDictionnary.selectVerticalMiddle;
                _listOutSelection = SetDictionnary.notSelectVerticalMiddle;
                AttachSeriesOfCubes.ToSelection(_listInSelection, _listOutSelection);
                break;
            case "Capteur6":
                _listInSelection = SetDictionnary.selectVerticalRight;
                _listOutSelection = SetDictionnary.notSelectVerticalRight;
                AttachSeriesOfCubes.ToSelection(_listInSelection, _listOutSelection);     
                break;
            case "Capteur7":
                _listInSelection = SetDictionnary.selectLateralFront;
                _listOutSelection = SetDictionnary.notSelectLateralFront;
                AttachSeriesOfCubes.ToSelection(_listInSelection, _listOutSelection);    
                break;
            case "Capteur8":
                _listInSelection = SetDictionnary.selectLateralMiddle;
                _listOutSelection = SetDictionnary.notSelectLateralMiddle;
                AttachSeriesOfCubes.ToSelection(_listInSelection, _listOutSelection);   
                break;
            case "Capteur9":
                _listInSelection = SetDictionnary.selectLateralBack;
                _listOutSelection = SetDictionnary.notSelectLateralBack;
                AttachSeriesOfCubes.ToSelection(_listInSelection, _listOutSelection);   
                break;
            case "Capteur10":
                _listInSelection = SetDictionnary.selectVerticalRight;
                _listOutSelection = SetDictionnary.notSelectVerticalRight;
                AttachSeriesOfCubes.ToSelection(_listInSelection, _listOutSelection);
                break;
            case "Capteur11":
                _listInSelection = SetDictionnary.selectVerticalMiddle;
                _listOutSelection = SetDictionnary.notSelectVerticalMiddle;
                AttachSeriesOfCubes.ToSelection(_listInSelection, _listOutSelection);  
                break;
            case "Capteur12":
                _listInSelection = SetDictionnary.selectVerticalLeft;
                _listOutSelection = SetDictionnary.notSelectVerticalLeft;
                AttachSeriesOfCubes.ToSelection(_listInSelection, _listOutSelection); 
                break;
            case "Capteur13":
                _listInSelection = SetDictionnary.selectLateralBack;
                _listOutSelection = SetDictionnary.notSelectLateralBack;
                AttachSeriesOfCubes.ToSelection(_listInSelection, _listOutSelection);
                break;
            case "Capteur14":
                _listInSelection = SetDictionnary.selectLateralMiddle;
                _listOutSelection = SetDictionnary.notSelectLateralMiddle;
                AttachSeriesOfCubes.ToSelection(_listInSelection, _listOutSelection);
                break;
            case "Capteur15":
                _listInSelection = SetDictionnary.selectLateralFront;
                _listOutSelection = SetDictionnary.notSelectLateralFront;
                AttachSeriesOfCubes.ToSelection(_listInSelection, _listOutSelection);
                break;
            case "Capteur16":
                _listInSelection = SetDictionnary.selectVerticalLeft;
                _listOutSelection = SetDictionnary.notSelectVerticalLeft;
                AttachSeriesOfCubes.ToSelection(_listInSelection, _listOutSelection);
                break;
            case "Capteur17":
                _listInSelection = SetDictionnary.selectVerticalMiddle;
                _listOutSelection = SetDictionnary.notSelectVerticalMiddle;
                AttachSeriesOfCubes.ToSelection(_listInSelection, _listOutSelection);
                break;
            case "Capteur18":
                _listInSelection = SetDictionnary.selectVerticalRight;
                _listOutSelection = SetDictionnary.notSelectVerticalRight;
                AttachSeriesOfCubes.ToSelection(_listInSelection, _listOutSelection);
                break;
            case "Capteur19":
                _listInSelection = SetDictionnary.selectHorizontalUp;
                _listOutSelection = SetDictionnary.notSelectHorizontalUp;
                AttachSeriesOfCubes.ToSelection(_listInSelection, _listOutSelection);
                break;
            case "Capteur20":
                _listInSelection = SetDictionnary.selectHorizontalUp;
                _listOutSelection = SetDictionnary.notSelectHorizontalUp;
                AttachSeriesOfCubes.ToSelection(_listInSelection, _listOutSelection);
                break;
            case "Capteur21":
                _listInSelection = SetDictionnary.selectHorizontalUp;
                _listOutSelection = SetDictionnary.notSelectHorizontalUp;
                AttachSeriesOfCubes.ToSelection(_listInSelection, _listOutSelection);
                break;
            case "Capteur22":
                _listInSelection = SetDictionnary.selectHorizontalUp;
                _listOutSelection = SetDictionnary.notSelectHorizontalUp;
                AttachSeriesOfCubes.ToSelection(_listInSelection, _listOutSelection);
                break;
            case "Capteur23":
                _listInSelection = SetDictionnary.selectHorizontalMiddle;
                _listOutSelection = SetDictionnary.notSelectHorizontalMiddle;
                AttachSeriesOfCubes.ToSelection(_listInSelection, _listOutSelection);
                break;
            case "Capteur24":
                 _listInSelection = SetDictionnary.selectHorizontalMiddle;
                _listOutSelection = SetDictionnary.notSelectHorizontalMiddle;
                AttachSeriesOfCubes.ToSelection(_listInSelection, _listOutSelection);
                break;
            case "Capteur25":
               _listInSelection = SetDictionnary.selectHorizontalMiddle;
                _listOutSelection = SetDictionnary.notSelectHorizontalMiddle;
                AttachSeriesOfCubes.ToSelection(_listInSelection, _listOutSelection);
                break;
            case "Capteur26":
                   _listInSelection = SetDictionnary.selectHorizontalMiddle;
                _listOutSelection = SetDictionnary.notSelectHorizontalMiddle;
                AttachSeriesOfCubes.ToSelection(_listInSelection, _listOutSelection);
                break;
            case "Capteur27":
                _listInSelection = SetDictionnary.selectHorizontalDown;
                _listOutSelection = SetDictionnary.notSelectHorizontalDown;
                AttachSeriesOfCubes.ToSelection(_listInSelection, _listOutSelection);
                break;
            case "Capteur28":
                _listInSelection = SetDictionnary.selectHorizontalDown;
                _listOutSelection = SetDictionnary.notSelectHorizontalDown;
                AttachSeriesOfCubes.ToSelection(_listInSelection, _listOutSelection);
                break;
            case "Capteur29":
                _listInSelection = SetDictionnary.selectHorizontalDown;
                _listOutSelection = SetDictionnary.notSelectHorizontalDown;
                AttachSeriesOfCubes.ToSelection(_listInSelection, _listOutSelection);
                break;
            case "Capteur30":
                _listInSelection = SetDictionnary.selectHorizontalDown;
                _listOutSelection = SetDictionnary.notSelectHorizontalDown;
                AttachSeriesOfCubes.ToSelection(_listInSelection, _listOutSelection);
                break;
            case "Capteur31":     
                _listInSelection = SetDictionnary.selectLateralBack;
                _listOutSelection = SetDictionnary.notSelectLateralBack;
                AttachSeriesOfCubes.ToSelection(_listInSelection, _listOutSelection);
                break;
            case "Capteur32":        
                _listInSelection = SetDictionnary.selectLateralMiddle;
                _listOutSelection = SetDictionnary.notSelectLateralMiddle;
                AttachSeriesOfCubes.ToSelection(_listInSelection, _listOutSelection);
                break;
            case "Capteur33":        
                _listInSelection = SetDictionnary.selectLateralFront;
                _listOutSelection = SetDictionnary.notSelectLateralFront;
                AttachSeriesOfCubes.ToSelection(_listInSelection, _listOutSelection);
                break;
            case "Capteur34":
                _listInSelection = SetDictionnary.selectVerticalLeft;
                _listOutSelection = SetDictionnary.notSelectVerticalLeft;
                AttachSeriesOfCubes.ToSelection(_listInSelection, _listOutSelection);
                break;
            case "Capteur35":
                _listInSelection = SetDictionnary.selectVerticalMiddle;
                _listOutSelection = SetDictionnary.notSelectVerticalMiddle;
                AttachSeriesOfCubes.ToSelection(_listInSelection, _listOutSelection);
                break;
            case "Capteur36":
                _listInSelection = SetDictionnary.selectVerticalRight;
                _listOutSelection = SetDictionnary.notSelectVerticalRight;
                AttachSeriesOfCubes.ToSelection(_listInSelection, _listOutSelection);
                break;   
        }
    }
}
