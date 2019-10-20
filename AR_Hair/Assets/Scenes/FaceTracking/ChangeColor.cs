using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    public GameObject hairs;
    [SerializeField]
    public List<Material> ListOfMaterials;
    public void ChangeColors()
    {
        hairs = GameObject.Find("FaceMeshPrefab");
        if (hairs != null)
            hairs.GetComponentInChildren<MeshRenderer>().material = ListOfMaterials[1];
        else
            GameObject.Find("Butt1").GetComponentInChildren<Text>().text = "no prefab found";
    }
}


   
