using UnityEngine;
using UnityEngine.Events; 


public class XRayObjects : MonoBehaviour
{
    MeshRenderer meshRenderer;
    Material baseMaterial;
    public Material xRayMaterial;
    int baseLayer; 

    //public UnityEvent onXray;
    //public UnityEvent offXray; 

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        baseMaterial = meshRenderer.material;
        baseLayer = gameObject.layer; 

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Camera.main.transform.position - transform.position, out hit))
        {
            if(hit.collider.CompareTag("Player") == false)
            {
                gameObject.layer = 7;// the number here is the number of the layer in the Unity Inspector. in layers "Player" layer is number 7. 
                meshRenderer.material = xRayMaterial;
                //onXray.Invoke(); 
            }
            else
            {
                gameObject.layer = baseLayer;
                meshRenderer.material = baseMaterial;
                //offXray.Invoke(); 
            }
        } 
    }
}
