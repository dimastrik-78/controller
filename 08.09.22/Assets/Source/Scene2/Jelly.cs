using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jelly : MonoBehaviour
{
    public static Jelly Instance;

    public GameObject[] Bones;

    public Vector3 Center;

    public SkinnedMeshRenderer SMRenderer;
    public Mesh playerBakedMesh;

    private void Awake()
    {
        Instance = this;
        
    }

    void FixedUpdate()
    {
        for (int i = 0; i < Bones.Length; i++)
        {
            Center += Bones[i].transform.position;
        }

        Center = Center / Bones.Length;

        transform.position = Center;

        Center = Vector3.zero;

        PlayerBakeMeshToCollider();
    }

    void PlayerBakeMeshToCollider()
    {
        SMRenderer.BakeMesh(playerBakedMesh);
        gameObject.GetComponent<MeshCollider>().sharedMesh = playerBakedMesh;
    }
}
