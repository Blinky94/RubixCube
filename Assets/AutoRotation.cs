using UnityEngine;
using System.Collections.Generic;

public static class AutoRotation
{
    /// <summary>
    /// Initialize
    /// </summary>
    public static void Initialize()
    {
        SetDictionnary.IdentifyCubeCollide();
        SetDictionnary.SetSeriesByCollider();
    }


     /// <summary>
    /// SetRotationSeriesFromPadSelected
    /// </summary>
    /// <param name="_rotationType"></param>
    public static void SetRotationSeriesByType(string _rotationType)
    {
        List<GameObject> _listInSelection = new List<GameObject>();
        List<GameObject> _listOutSelection = new List<GameObject>();
        Initialize();

        switch(_rotationType)
        {
            case "R":                              
                _listInSelection = SetDictionnary.selectVerticalRight;
                _listOutSelection = SetDictionnary.notSelectVerticalRight;
                AttachSeriesOfCubes.ToSelection(_listInSelection, _listOutSelection);    
                break;
            case "D":         
                _listInSelection = SetDictionnary.selectHorizontalDown;
                _listOutSelection = SetDictionnary.notSelectHorizontalDown;
                AttachSeriesOfCubes.ToSelection(_listInSelection, _listOutSelection);
                break;
            case "L":              
                _listInSelection = SetDictionnary.selectVerticalLeft;
                _listOutSelection = SetDictionnary.notSelectVerticalLeft;
                AttachSeriesOfCubes.ToSelection(_listInSelection, _listOutSelection);     
                break;
            case "F":                    
                _listInSelection = SetDictionnary.selectLateralFront;
                _listOutSelection = SetDictionnary.notSelectLateralFront;
                AttachSeriesOfCubes.ToSelection(_listInSelection, _listOutSelection);   
                break;
            case "B":            
                _listInSelection = SetDictionnary.selectLateralBack;
                _listOutSelection = SetDictionnary.notSelectLateralBack;
                AttachSeriesOfCubes.ToSelection(_listInSelection, _listOutSelection);   
                break;
            case "U":                     
                _listInSelection = SetDictionnary.selectHorizontalUp;
                _listOutSelection = SetDictionnary.notSelectHorizontalUp;
                AttachSeriesOfCubes.ToSelection(_listInSelection, _listOutSelection);
                break;
            case "Ri":
                _listInSelection = SetDictionnary.selectVerticalRight;
                _listOutSelection = SetDictionnary.notSelectVerticalRight;
                AttachSeriesOfCubes.ToSelection(_listInSelection, _listOutSelection);
                break;
            case "Di":
                _listInSelection = SetDictionnary.selectHorizontalDown;
                _listOutSelection = SetDictionnary.notSelectHorizontalDown;
                AttachSeriesOfCubes.ToSelection(_listInSelection, _listOutSelection);
                break;
            case "Li":
                _listInSelection = SetDictionnary.selectVerticalLeft;
                _listOutSelection = SetDictionnary.notSelectVerticalLeft;
                AttachSeriesOfCubes.ToSelection(_listInSelection, _listOutSelection);
                break;
            case "Fi":
                _listInSelection = SetDictionnary.selectLateralFront;
                _listOutSelection = SetDictionnary.notSelectLateralFront;
                AttachSeriesOfCubes.ToSelection(_listInSelection, _listOutSelection);
                break;
            case "Bi":
                _listInSelection = SetDictionnary.selectLateralBack;
                _listOutSelection = SetDictionnary.notSelectLateralBack;
                AttachSeriesOfCubes.ToSelection(_listInSelection, _listOutSelection);
                break;
            case "Ui":
                _listInSelection = SetDictionnary.selectHorizontalUp;
                _listOutSelection = SetDictionnary.notSelectHorizontalUp;
                AttachSeriesOfCubes.ToSelection(_listInSelection, _listOutSelection);
                break;
        }
    }
}
