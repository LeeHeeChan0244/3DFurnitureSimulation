using UnityEngine;


[CreateAssetMenu(fileName = "Furniture Data", menuName = "Scriptable Object/Furniture Data", order = int.MaxValue)]
public class FurnitureData : ScriptableObject
{
    [SerializeField]
    private string furnitureName;
    public string FurnitureName { get { return furnitureName; } }

    [SerializeField]
    private string furnitureNumber;
    public string FurnitureNumber { get { return furnitureNumber; } }

    [SerializeField]
    private GameObject furniturePrefab;
    public GameObject FurniturePrefab { get { return furniturePrefab; } }
}
