using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactColorChanger : MonoBehaviour
{

    public Material footballMaterial;

    // Start is called before the first frame update
    void Start()
    {
        footballMaterial = GetComponent<MeshRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        Color randomColor = Random.ColorHSV();
        footballMaterial.color = randomColor;
    }
}
