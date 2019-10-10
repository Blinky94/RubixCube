using System.Collections.Generic;
using UnityEngine;

public class MakeRandomCube : MonoBehaviour
{
	private List<int> seriesCubExt;
	private List<int> seriesCubMid;
	private List<int> seriesCubCtr;
	private List<Quaternion> serieOrientations;
	private List<Vector3> seriePositions;
	public static List<GameObject> listCubes;


	/// <summary>
   /// Initialize
	/// </summary>
	private void Initialize () 
	{
		listCubes = new List<GameObject>();
		seriesCubExt = new List<int>() { 1, 3, 7, 9, 19, 21, 25, 27 };//8
		seriesCubMid = new List<int>() { 2, 4, 6, 8, 10, 12, 16, 18, 20, 22, 24, 26 };//12
		seriesCubCtr = new List<int>() { 5, 11, 13, 15, 17, 23 };//6
 
		serieOrientations = new List<Quaternion>();
		seriePositions = new List<Vector3>();
		listCubes = IdentObj.GenerateListOfCubes();

		foreach(var cube in listCubes)
			serieOrientations.Add(cube.transform.rotation);


		foreach(var cube in listCubes)		
            seriePositions.Add(new Vector3(cube.transform.position.x, cube.transform.position.y, cube.transform.position.z));
	}


	/// <summary>
	/// GenerateRandomList
	/// </summary>
	/// <param name="_list"></param>
	/// <param name="_mixedList"></param>
	/// <returns></returns>
	private  List<int> GenerateRandomList(List<int> _list)
	{
		List<int> randomList = new List<int>();
		System.Random random;

		while (_list.Count != 0)
		{
			random = new System.Random();
			int num = random.Next(_list.Count);
			randomList.Add(_list[num]);
			_list.RemoveAt(num);
		}
		return randomList;
	}


	/// <summary>
	/// GenerateFinalList
	/// </summary>
	private  List<GameObject> GenerateFinalList ()
	{
		List<int> mixedSeriesCubExt = GenerateRandomList(seriesCubExt);
		List<int> mixedSeriesCubMid = GenerateRandomList(seriesCubMid);
		List<int> mixedSeriesCubCtr = GenerateRandomList(seriesCubCtr);

		List<int> mixedFinalList = new List<int>() {
			mixedSeriesCubExt[0],mixedSeriesCubMid[0],mixedSeriesCubExt[1],
			mixedSeriesCubMid[1],mixedSeriesCubCtr[0],mixedSeriesCubMid[2],
			mixedSeriesCubExt[2],mixedSeriesCubMid[3],mixedSeriesCubExt[3],

			mixedSeriesCubMid[4],mixedSeriesCubCtr[1],mixedSeriesCubMid[5],
			mixedSeriesCubCtr[2],mixedSeriesCubCtr[3],
			mixedSeriesCubMid[6],mixedSeriesCubCtr[4],mixedSeriesCubMid[7],

			mixedSeriesCubExt[4],mixedSeriesCubMid[8],mixedSeriesCubExt[5],
			mixedSeriesCubMid[9],mixedSeriesCubCtr[5],mixedSeriesCubMid[10],
			mixedSeriesCubExt[6],mixedSeriesCubMid[11],mixedSeriesCubExt[7]
		};

		List<GameObject> finalList = new List<GameObject>()
		{
			listCubes[mixedFinalList[0]-1], listCubes[mixedFinalList[1]-1],    listCubes[mixedFinalList[2]-1],          
			listCubes[mixedFinalList[3]-1], listCubes[mixedFinalList[4]-1],    listCubes[mixedFinalList[5]-1],        
			listCubes[mixedFinalList[6]-1], listCubes[mixedFinalList[7]-1],    listCubes[mixedFinalList[8]-1],
		  
			listCubes[mixedFinalList[9]-1], listCubes[mixedFinalList[10]-1],  listCubes[mixedFinalList[11]-1],         
			listCubes[mixedFinalList[12]-1],           listCubes[13],         listCubes[mixedFinalList[13]-1],        
			listCubes[mixedFinalList[14]-1], listCubes[mixedFinalList[15]-1], listCubes[mixedFinalList[16]-1],
	   
			listCubes[mixedFinalList[17]-1], listCubes[mixedFinalList[18]-1], listCubes[mixedFinalList[19]-1],         
			listCubes[mixedFinalList[20]-1], listCubes[mixedFinalList[21]-1], listCubes[mixedFinalList[22]-1],          
			listCubes[mixedFinalList[23]-1], listCubes[mixedFinalList[24]-1], listCubes[mixedFinalList[25]-1]
		};
		return finalList;    
	}


    /// <summary>
    /// SetPosition
    /// </summary>
    /// <param name="list"></param>
	private void SetPosition(List<GameObject> list)
	{
		for (int i = 0; i < list.Count; i++)     
			list[i].transform.position = seriePositions[i];
	}


    /// <summary>
    /// SetRotation
    /// </summary>
    /// <param name="list"></param>
	private void SetRotation(List<GameObject> list)
	{
		for (int i = 0; i < list.Count; i++)
			list[i].transform.rotation = serieOrientations[i];  
	}


    /// <summary>
    /// Start
    /// </summary>
	void Start()
	{
		Initialize();
		List<GameObject> list = GenerateFinalList(); 
		SetPosition(list);
		SetRotation(list);

        listCubes = IdentObj.GetListOfCubes(list);
	}
}
