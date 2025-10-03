using UnityEngine;

public enum ObjectMaterials
{
    Wood = 0,
    Glass,
    Plastic
}

public enum Cleaners
{
    Water = 0,
    Bleach,
    Peroxide,
    Soap
}

public class Cleanable : MonoBehaviour
{
    [SerializeField]
    public string ObjectName;
    [SerializeField]
    public ObjectMaterials ObjectMaterial;

    private string name;
    private ObjectMaterials material;
}
