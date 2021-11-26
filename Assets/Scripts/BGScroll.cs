using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroll : MonoBehaviour
{
    public float scroll_Speed = 0.1f;
    private MeshRenderer Renderer;
    private float x_Scroll;

    
    void Awake()
    {
        Renderer = GetComponent<MeshRenderer>();
    }

   
    void Update()
    {
        Scroll();
    }
    void Scroll()
    {
        x_Scroll = Time.time * scroll_Speed;
        Vector2 offset = new Vector2(x_Scroll, 0f);
        Renderer.sharedMaterial.SetTextureOffset("_MainTex", offset);
    }
}
