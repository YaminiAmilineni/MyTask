using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroll : MonoBehaviour
{
    public float scroll_Speed = 0.1f;
    private MeshRenderer mesh_Renderer;
    private float y_Scroll;

    
    void Awake()
    {
        mesh_Renderer = GetComponent<MeshRenderer>();
    }

   
    void Update()
    {
        Scroll();
    }
    void Scroll()
    {
        y_Scroll = Time.time * scroll_Speed;
        Vector2 offset = new Vector2(y_Scroll, 0f);
        mesh_Renderer.sharedMaterial.SetTextureOffset("_MainTex", offset);
    }
}
