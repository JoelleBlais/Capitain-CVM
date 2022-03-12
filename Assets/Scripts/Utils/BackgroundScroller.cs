using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// ****************************
// Référence: Youtube à l'adresse suivante: https://www.youtube.com/watch?v=A5YSbgqr3sc
// visité le 12 mars 2022
// ****************************


public class BackgroundScroller : MonoBehaviour
{
    [Range(-1f,1f)]
    public float scrollSpeed = 0.5f;
    private float offset;
    private Material mat;


    // Start is called before the first frame update
    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        offset += (Time.deltaTime * scrollSpeed) / 10f;
        mat.SetTextureOffset("_MainTex", new Vector2(offset, 0));
    }
}
