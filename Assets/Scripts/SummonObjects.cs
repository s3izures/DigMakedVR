using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummonObjects : MonoBehaviour
{
    [SerializeField] List<GameObject> objects;
    [SerializeField] List<MeshRenderer> objectRends;
    [SerializeField] List<Material> materials;
    Material selectedMat = null;

    public enum Obj
    {
        Cube,
        LongCube,
        Sphere
    }
    public enum Mats
    {
        Red,        Orange,     Yellow,
        Green,      Blue,       Purple,
        Pink,       White,      Black
    }

    private void Start()
    {
        selectedMat = materials[(int)Mats.White];
    }

    public void SummonObject(int which)
    {
        int pick = which;
        objectRends[pick].material = selectedMat;
        Instantiate(objects[pick]);
    }
    public void SetMaterial(int which)
    {
        int pick = which;
        selectedMat = materials[pick];
    }
}
