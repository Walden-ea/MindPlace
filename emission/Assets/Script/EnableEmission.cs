using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableEmission : MonoBehaviour
{

    public bool emis;
    private MeshRenderer ren;
    public Material MaterialEmissionOn;
    public Material MaterialEmissionOff;
    public string ButtonNotUI;


    // Start is called before the first frame update
    void Start()
    {
        Renderer ren = GetComponent<MeshRenderer>();
        ren.material = MaterialEmissionOff;
    }
    // Update is called once per frame
    void Update()
    {
        Renderer ren = GetComponent<MeshRenderer>();
        
        if(emis)      
            ren.material = MaterialEmissionOn;        
        else 
            ren.material = MaterialEmissionOff;

        emis = Input.GetButton(ButtonNotUI);
    }
}
