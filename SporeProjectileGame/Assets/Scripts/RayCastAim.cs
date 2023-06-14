using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class RayCastAim : MonoBehaviour
{
    private Camera cam = null;
    public LayerMask mask;

    Vector3 aimCubePosition;
    Vector3 AimCubePosition;
    Vector3 RayTest;

    public GameObject rayCastGroundTest = null; 

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main; 
    }

    // Update is called once per frame
    void Update()
    {
        DrawRay(); 
    }

    void DrawRay()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 10f;
        mousePos = cam.ScreenToWorldPoint(mousePos);

        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Input.GetMouseButtonDown(0))
        {

            if (Physics.Raycast(ray, out hit, 500, mask))
            {
                transform.LookAt(new Vector3(hit.point.x, 1.35f, hit.point.z)); //Testing to see if camera will rotate. 

                
                Instantiate(rayCastGroundTest, new Vector3(hit.point.x, hit.point.y, hit.point.z), Quaternion.identity);

                aimCubePosition = hit.point;
                AimCubePosition = hit.normal;
                RayTest = hit.point;
                Debug.Log(RayTest);
            }

            if (Physics.Raycast(ray, out hit, 500, mask))
            {
                Debug.Log(hit.transform.name);
                hit.transform.GetComponent<Renderer>().material.color = Color.red;
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(aimCubePosition, 0.5f);

    }
}
