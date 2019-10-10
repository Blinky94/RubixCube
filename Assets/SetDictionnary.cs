using UnityEngine;
using System.Collections.Generic;

public static class SetDictionnary
{
    public static List<GameObject> selectAll, selectHorizontalUp,
        selectHorizontalMiddle,selectHorizontalDown,
        selectVerticalRight,selectVerticalLeft,
        selectVerticalMiddle, selectLateralFront,
        selectLateralMiddle,selectLateralBack;

    public static List<GameObject>  
        notSelectHorizontalUp,notSelectHorizontalMiddle,notSelectHorizontalDown,
        notSelectVerticalLeft,notSelectVerticalMiddle,notSelectVerticalRight,
        notSelectLateralFront,notSelectLateralMiddle,notSelectLateralBack;


    /// <summary>
    /// IdentifyCubeCollide
    /// </summary>
    public static void IdentifyCubeCollide()
    {
        IdentObj.IdentifyColliders();
    }


    /// <summary>
    /// SetSeriesByColliders
    /// </summary>
    public static void SetSeriesByCollider()
    {
        selectAll = new List<GameObject>() 
        { 
            IdentObj.Collider1, IdentObj.Collider2,IdentObj.Collider3,
            IdentObj.Collider4, IdentObj.Collider5, IdentObj.Collider6, 
            IdentObj.Collider7, IdentObj.Collider8, IdentObj.Collider9,   
            IdentObj.Collider10, IdentObj.Collider11, IdentObj.Collider12, 
            IdentObj.Collider13, IdentObj.Collider14, IdentObj.Collider15, 
            IdentObj.Collider16, IdentObj.Collider17, IdentObj.Collider18,    
            IdentObj.Collider19, IdentObj.Collider20, IdentObj.Collider21, 
            IdentObj.Collider22, IdentObj.Collider23, IdentObj.Collider24, 
            IdentObj.Collider25, IdentObj.Collider26, IdentObj.Collider27
        };
       
        selectHorizontalUp = new List<GameObject>()
        { 
            IdentObj.Collider1, IdentObj.Collider2, IdentObj.Collider3, 
            IdentObj.Collider10, IdentObj.Collider11, IdentObj.Collider12, 
            IdentObj.Collider19, IdentObj.Collider20, IdentObj.Collider21
        };

        notSelectHorizontalUp = new List<GameObject>() 
        {  
            IdentObj.Collider4, IdentObj.Collider5, IdentObj.Collider6,
            IdentObj.Collider7, IdentObj.Collider8, IdentObj.Collider9,    
            IdentObj.Collider13, IdentObj.Collider14, IdentObj.Collider15, 
            IdentObj.Collider16, IdentObj.Collider17, IdentObj.Collider18,      
            IdentObj.Collider22, IdentObj.Collider23, IdentObj.Collider24, 
            IdentObj.Collider25, IdentObj.Collider26, IdentObj.Collider27 
        };

        selectHorizontalMiddle = new List<GameObject>()
        {
            IdentObj.Collider4, IdentObj.Collider5, IdentObj.Collider6, 
            IdentObj.Collider13, IdentObj.Collider14, IdentObj.Collider15, 
            IdentObj.Collider22, IdentObj.Collider23, IdentObj.Collider24
        };

        notSelectHorizontalMiddle = new List<GameObject>()     
        {
            IdentObj.Collider1, IdentObj.Collider2, IdentObj.Collider3,
            IdentObj.Collider7, IdentObj.Collider8, IdentObj.Collider9,       
            IdentObj.Collider10, IdentObj.Collider11, IdentObj.Collider12,                
            IdentObj.Collider16, IdentObj.Collider17, IdentObj.Collider18,       
            IdentObj.Collider19, IdentObj.Collider20, IdentObj.Collider21,     
            IdentObj.Collider25, IdentObj.Collider26, IdentObj.Collider27 
        };

        selectHorizontalDown = new List<GameObject>() 
        { 
            IdentObj.Collider7, IdentObj.Collider8, IdentObj.Collider9, 
            IdentObj.Collider16, IdentObj.Collider17, IdentObj.Collider18, 
            IdentObj.Collider25, IdentObj.Collider26, IdentObj.Collider27 
        };

        notSelectHorizontalDown = new List<GameObject>()
        { 
            IdentObj.Collider1, IdentObj.Collider2, IdentObj.Collider3, 
            IdentObj.Collider4, IdentObj.Collider5, IdentObj.Collider6,      
            IdentObj.Collider10, IdentObj.Collider11, IdentObj.Collider12,       
            IdentObj.Collider13, IdentObj.Collider14, IdentObj.Collider15,       
            IdentObj.Collider19, IdentObj.Collider20, IdentObj.Collider21,     
            IdentObj.Collider22, IdentObj.Collider23, IdentObj.Collider24 
        };

        selectVerticalLeft = new List<GameObject>() 
        { 
            IdentObj.Collider1, IdentObj.Collider4, IdentObj.Collider7, 
            IdentObj.Collider10, IdentObj.Collider13, IdentObj.Collider16,
            IdentObj.Collider19, IdentObj.Collider22, IdentObj.Collider25
        };

        notSelectVerticalLeft = new List<GameObject>()
        {
            IdentObj. Collider2, IdentObj.Collider3,  IdentObj.Collider5, 
            IdentObj.Collider6,  IdentObj.Collider8, IdentObj.Collider9,       
            IdentObj.Collider11, IdentObj.Collider12,  IdentObj.Collider14,        
            IdentObj.Collider15,  IdentObj.Collider17, IdentObj.Collider18,       
            IdentObj.Collider20, IdentObj.Collider21,  IdentObj.Collider23,        
            IdentObj.Collider24,  IdentObj.Collider26, IdentObj.Collider27
        };

        selectVerticalMiddle = new List<GameObject>()
        { 
            IdentObj.Collider2, IdentObj.Collider5, IdentObj.Collider8,
            IdentObj.Collider11, IdentObj.Collider14, IdentObj.Collider17, 
            IdentObj.Collider20, IdentObj.Collider23, IdentObj.Collider26 
        };

        notSelectVerticalMiddle = new List<GameObject>()       
        {
            IdentObj.Collider1,  IdentObj.Collider3, IdentObj.Collider4,  
            IdentObj.Collider6, IdentObj.Collider7,  IdentObj.Collider9,     
            IdentObj.Collider10,  IdentObj.Collider12, IdentObj.Collider13,     
            IdentObj.Collider15, IdentObj.Collider16,  IdentObj.Collider18,      
            IdentObj.Collider19,  IdentObj.Collider21, IdentObj.Collider22,    
            IdentObj.Collider24, IdentObj.Collider25,  IdentObj.Collider27 
        };

        selectVerticalRight = new List<GameObject>()
        {
            IdentObj.Collider3, IdentObj.Collider6, IdentObj.Collider9,
            IdentObj.Collider12, IdentObj.Collider15, IdentObj.Collider18,
            IdentObj.Collider21, IdentObj.Collider24, IdentObj.Collider27 
        };

        notSelectVerticalRight = new List<GameObject>() 
        { 
            IdentObj.Collider1, IdentObj.Collider2,  IdentObj.Collider4, 
            IdentObj.Collider5,  IdentObj.Collider7, IdentObj.Collider8,       
            IdentObj.Collider10, IdentObj.Collider11,  IdentObj.Collider13,       
            IdentObj.Collider14,  IdentObj.Collider16, IdentObj.Collider17,       
            IdentObj.Collider19, IdentObj.Collider20,  IdentObj.Collider22,        
            IdentObj.Collider23,  IdentObj.Collider25, IdentObj.Collider26 
        };

        selectLateralFront = new List<GameObject>()
        { 
            IdentObj.Collider1, IdentObj.Collider2, IdentObj.Collider3, 
            IdentObj.Collider4, IdentObj.Collider5, IdentObj.Collider6,
            IdentObj.Collider7, IdentObj.Collider8, IdentObj.Collider9
        };

        notSelectLateralFront = new List<GameObject>()     
        { 
            IdentObj.Collider10, IdentObj.Collider11, IdentObj.Collider12, 
            IdentObj.Collider13, IdentObj.Collider14, IdentObj.Collider15,
            IdentObj.Collider16, IdentObj.Collider17, IdentObj.Collider18,      
            IdentObj.Collider19, IdentObj.Collider20, IdentObj.Collider21,       
            IdentObj.Collider22, IdentObj.Collider23, IdentObj.Collider24,   
            IdentObj.Collider25, IdentObj.Collider26, IdentObj.Collider27 
        };

        selectLateralMiddle = new List<GameObject>()
        {
            IdentObj.Collider10, IdentObj.Collider11, IdentObj.Collider12, 
            IdentObj.Collider13, IdentObj.Collider14, IdentObj.Collider15, 
            IdentObj.Collider16, IdentObj.Collider17, IdentObj.Collider18
        };

        notSelectLateralMiddle = new List<GameObject>()     
        {
            IdentObj.Collider1, IdentObj.Collider2, IdentObj.Collider3, 
            IdentObj.Collider4, IdentObj.Collider5, IdentObj.Collider6, 
            IdentObj.Collider7, IdentObj.Collider8, IdentObj.Collider9,      
            IdentObj.Collider19, IdentObj.Collider20, IdentObj.Collider21,       
            IdentObj.Collider22, IdentObj.Collider23, IdentObj.Collider24,      
            IdentObj.Collider25, IdentObj.Collider26, IdentObj.Collider27
        };

        selectLateralBack = new List<GameObject>() 
        { 
            IdentObj.Collider19, IdentObj.Collider20, IdentObj.Collider21,
            IdentObj.Collider22, IdentObj.Collider23, IdentObj.Collider24, 
            IdentObj.Collider25, IdentObj.Collider26, IdentObj.Collider27 
        };

        notSelectLateralBack = new List<GameObject>()      
        { 
            IdentObj.Collider1, IdentObj.Collider2, IdentObj.Collider3, 
            IdentObj.Collider4, IdentObj.Collider5, IdentObj.Collider6,
            IdentObj.Collider7, IdentObj.Collider8, IdentObj.Collider9,    
            IdentObj.Collider10, IdentObj.Collider11, IdentObj.Collider12,      
            IdentObj.Collider13, IdentObj.Collider14, IdentObj.Collider15,     
            IdentObj.Collider16, IdentObj.Collider17, IdentObj.Collider18 
        };
    }
}
