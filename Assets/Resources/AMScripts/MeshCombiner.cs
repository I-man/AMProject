using UnityEngine;
using System.Collections;
[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class MeshCombiner : MonoBehaviour {

    void start()
    {
        CombineMeshes();
    }


    public void CombineMeshes()
    {
        Quaternion oldRot = transform.rotation;
        Vector3 oldPos = Vector3.zero;

        transform.rotation = Quaternion.identity;
        transform.position = Vector3.zero;

        MeshFilter[] filters = GetComponentsInChildren<MeshFilter>();
        Mesh finalMesh = new Mesh();
        CombineInstance[] combiners = new CombineInstance[filters.Length];

        for(int a = 0; a < filters.Length; a++)
        {
            if (filters[a].transform == transform)
            {
                continue;
            }
            combiners[a].subMeshIndex = 0;
            combiners[a].mesh = filters[a].sharedMesh;
            combiners[a].transform = filters[a].transform.localToWorldMatrix;
        }
        finalMesh.CombineMeshes(combiners);
        GetComponent<MeshFilter>().sharedMesh = finalMesh;

        transform.position = oldPos;
        transform.rotation = oldRot;

        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(false);
        }
    }
}
