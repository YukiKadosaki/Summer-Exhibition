using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    private Vector4 color;

    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        color = meshRenderer.material.color;
    }

    public void PositionChange(Vector3 position)
    {
        this.transform.position = position;
    }

    public void VisibleChange(bool isvisible)
    {
        meshRenderer.enabled = isvisible;
    }

    public void AlphaChange(float alpha)
    {
        color.w = alpha;
        meshRenderer.material.color = this.color;
        Debug.Log(meshRenderer.material.color);
    }
}
