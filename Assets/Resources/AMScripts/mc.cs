using UnityEngine;
using System.Collections;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class mc : MonoBehaviour
{
    Quaternion oldRot;
    Vector3 oldPos;
    void Start()
    {
        oldRot = transform.rotation;
        oldPos = Vector3.zero;

        transform.rotation = Quaternion.identity;
        transform.position = Vector3.zero;

        MeshFilter[] meshFilters = GetComponentsInChildren<MeshFilter>();
        CombineInstance[] combine = new CombineInstance[meshFilters.Length];
        int i = 0;
        while (i < meshFilters.Length)
        {
            combine[i].mesh = meshFilters[i].sharedMesh;
            combine[i].transform = meshFilters[i].transform.localToWorldMatrix;
            meshFilters[i].gameObject.SetActive(false);
            i++;
        }

        
        transform.GetComponent<MeshFilter>().sharedMesh = new Mesh();
        transform.GetComponent<MeshFilter>().sharedMesh.CombineMeshes(combine);
        transform.position = oldPos;
        transform.rotation = oldRot;
        transform.gameObject.SetActive(true);
    }
}