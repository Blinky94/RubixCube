using UnityEngine;
using System.Collections.Generic;

public static class IdentObj 
{
	 public static GameObject Collider1, Collider2, Collider3, Collider4, Collider5, Collider6, Collider7, Collider8, Collider9,
		Collider10, Collider11, Collider12, Collider13, Collider14, Collider15, Collider16, Collider17, Collider18,
		Collider19, Collider20, Collider21, Collider22, Collider23, Collider24, Collider25, Collider26, Collider27;

	 public static GameObject InSelection, OutSelection;

	 public static GameObject RotationPadUp, RotationPadLeft,
						   RotationPadRight, RotationPadDown,
						   RotationPadForward, RotationPadBackward,
						   RotationPadForward2, RotationPadBackward2;

	 public static GameObject Capteur1, Capteur2, Capteur3, Capteur4, Capteur5, Capteur6, Capteur7, Capteur8, Capteur9, Capteur10,
		 Capteur11, Capteur12, Capteur13, Capteur14, Capteur15, Capteur16, Capteur17, Capteur18, Capteur19, Capteur20, Capteur21,
		 Capteur22, Capteur23, Capteur24, Capteur25, Capteur26, Capteur27, Capteur28, Capteur29, Capteur30, Capteur31, Capteur32, Capteur33,
		 Capteur34, Capteur35, Capteur36;


	/// <summary>
	 /// IdentifyColliders
	/// </summary>
	public static void IdentifyColliders ()
	{   
		Collider1 = GameObject.Find("Collider1").GetComponent<IdentifyCube>().currentCube;
		Collider2 = GameObject.Find("Collider2").GetComponent<IdentifyCube>().currentCube;
		Collider3 = GameObject.Find("Collider3").GetComponent<IdentifyCube>().currentCube;
		Collider4 = GameObject.Find("Collider4").GetComponent<IdentifyCube>().currentCube;
		Collider5 = GameObject.Find("Collider5").GetComponent<IdentifyCube>().currentCube;
		Collider6 = GameObject.Find("Collider6").GetComponent<IdentifyCube>().currentCube;
		Collider7 = GameObject.Find("Collider7").GetComponent<IdentifyCube>().currentCube;
		Collider8 = GameObject.Find("Collider8").GetComponent<IdentifyCube>().currentCube;
		Collider9 = GameObject.Find("Collider9").GetComponent<IdentifyCube>().currentCube;
		Collider10 = GameObject.Find("Collider10").GetComponent<IdentifyCube>().currentCube;
		Collider11 = GameObject.Find("Collider11").GetComponent<IdentifyCube>().currentCube;
		Collider12 = GameObject.Find("Collider12").GetComponent<IdentifyCube>().currentCube;
		Collider13 = GameObject.Find("Collider13").GetComponent<IdentifyCube>().currentCube;
		Collider14 = GameObject.Find("Collider14").GetComponent<IdentifyCube>().currentCube;
		Collider15 = GameObject.Find("Collider15").GetComponent<IdentifyCube>().currentCube;
		Collider16 = GameObject.Find("Collider16").GetComponent<IdentifyCube>().currentCube;
		Collider17 = GameObject.Find("Collider17").GetComponent<IdentifyCube>().currentCube;
		Collider18 = GameObject.Find("Collider18").GetComponent<IdentifyCube>().currentCube;
		Collider19 = GameObject.Find("Collider19").GetComponent<IdentifyCube>().currentCube;
		Collider20 = GameObject.Find("Collider20").GetComponent<IdentifyCube>().currentCube;
		Collider21 = GameObject.Find("Collider21").GetComponent<IdentifyCube>().currentCube;
		Collider22 = GameObject.Find("Collider22").GetComponent<IdentifyCube>().currentCube;
		Collider23 = GameObject.Find("Collider23").GetComponent<IdentifyCube>().currentCube;
		Collider24 = GameObject.Find("Collider24").GetComponent<IdentifyCube>().currentCube;
		Collider25 = GameObject.Find("Collider25").GetComponent<IdentifyCube>().currentCube;
		Collider26 = GameObject.Find("Collider26").GetComponent<IdentifyCube>().currentCube;
		Collider27 = GameObject.Find("Collider27").GetComponent<IdentifyCube>().currentCube;	
	}	


	/// <summary>
	/// IdentifySelection
	/// </summary>
	public static void IdentifySelection()
	{
		InSelection = GameObject.Find("InSelection");
		OutSelection = GameObject.Find("OutSelection");
	}


	/// <summary>
	/// IdentifyPadRotation
	/// </summary>
	public static void IdentifyPadRotation()
	{
		RotationPadUp = GameObject.Find("RotationPadUp");
		RotationPadLeft = GameObject.Find("RotationPadLeft");
		RotationPadRight = GameObject.Find("RotationPadRight");
		RotationPadDown = GameObject.Find("RotationPadDown");
		RotationPadForward = GameObject.Find("RotationPadForward");
		RotationPadBackward = GameObject.Find("RotationPadBackward");
		RotationPadForward2 = GameObject.Find("RotationPadForward2");
		RotationPadBackward2 = GameObject.Find("RotationPadBackward2");

		Capteur1 = GameObject.Find("Capteur1");
		Capteur2 = GameObject.Find("Capteur2");
		Capteur3 = GameObject.Find("Capteur3");
		Capteur4 = GameObject.Find("Capteur4");
		Capteur5 = GameObject.Find("Capteur5");
		Capteur6 = GameObject.Find("Capteur6");
		Capteur7 = GameObject.Find("Capteur7");
		Capteur8 = GameObject.Find("Capteur8");
		Capteur9 = GameObject.Find("Capteur9");
		Capteur10 = GameObject.Find("Capteur10");
		Capteur11 = GameObject.Find("Capteur11");
		Capteur12 = GameObject.Find("Capteur12");
		Capteur13 = GameObject.Find("Capteur13");
		Capteur14 = GameObject.Find("Capteur14");
		Capteur15 = GameObject.Find("Capteur15");
		Capteur16 = GameObject.Find("Capteur16");
		Capteur17 = GameObject.Find("Capteur17");
		Capteur18 = GameObject.Find("Capteur18");
		Capteur19 = GameObject.Find("Capteur19");
		Capteur20 = GameObject.Find("Capteur20");
		Capteur21 = GameObject.Find("Capteur21");
		Capteur22 = GameObject.Find("Capteur22");
		Capteur23 = GameObject.Find("Capteur23");
		Capteur24 = GameObject.Find("Capteur24");
		Capteur25 = GameObject.Find("Capteur25");
		Capteur26 = GameObject.Find("Capteur26");
		Capteur27 = GameObject.Find("Capteur27");
		Capteur28 = GameObject.Find("Capteur28");
		Capteur29 = GameObject.Find("Capteur29");
		Capteur30 = GameObject.Find("Capteur30");
		Capteur31 = GameObject.Find("Capteur31");
		Capteur32 = GameObject.Find("Capteur32");
		Capteur33 = GameObject.Find("Capteur33");
		Capteur34 = GameObject.Find("Capteur34");
		Capteur35 = GameObject.Find("Capteur35");
		Capteur36 = GameObject.Find("Capteur36");
	}


	/// <summary>
	/// GenerateListOfCubes
	/// </summary>
	/// <returns>listCubes</returns>
	public static List<GameObject> GenerateListOfCubes()
	{
		List<GameObject> listCubes = new List<GameObject>()
		{             
			GameObject.Find("1"), GameObject.Find("2"), GameObject.Find("3"),
			GameObject.Find("4"), GameObject.Find("5"), GameObject.Find("6"),       
			GameObject.Find("7"), GameObject.Find("8"), GameObject.Find("9"),
			GameObject.Find("10"), GameObject.Find("11"), GameObject.Find("12"),
			GameObject.Find("13"), GameObject.Find("14"), GameObject.Find("15"),
			GameObject.Find("16"), GameObject.Find("17"), GameObject.Find("18"),
			GameObject.Find("19"), GameObject.Find("20"), GameObject.Find("21"),
			GameObject.Find("22"), GameObject.Find("23"), GameObject.Find("24"),
			GameObject.Find("25"), GameObject.Find("26"), GameObject.Find("27")
		};
	  
		return listCubes;
	}

  
    /// <summary>
    /// GetListOfCubes
    /// </summary>
    /// <param name="list"></param>
    /// <returns></returns>
    public static List<GameObject> GetListOfCubes(List<GameObject> list)
    {
        return list;
    }
}
