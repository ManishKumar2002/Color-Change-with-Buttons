using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Renderer SphereRenderer;
    public GameObject Sphere;
    [SerializeField] private Color newColor;
    
    // Start is called before the first frame update
    void Start()
    {
        SphereRenderer = Sphere.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeMaterial()
    {
        SphereRenderer.material.color = newColor;
        
    }
}
