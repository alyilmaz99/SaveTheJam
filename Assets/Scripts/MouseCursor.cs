
/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCursor : MonoBehaviour
{

    public LayerMask mask;
    [SerializeField] private GameObject parentObject;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        MouseClick();

    }

    void MouseClick()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("ilk");
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit,mask))
            {
                Debug.Log("ikii");
                hit.collider.gameObject.GetComponentInParent<GroundStats>().mouseCheck = true;

                if(parentObject!= hit.collider.gameObject.transform.parent.gameObject)
                {
                    if(parentObject != null)
                    parentObject.GetComponent<GroundStats>().mouseCheck = false;
                }

                parentObject = hit.collider.gameObject.transform.parent.gameObject;
            }
            else if(parentObject!=null) {
                parentObject.GetComponent<GroundStats>().mouseCheck = false;
            }
        }

    }
}
*/
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCursor : MonoBehaviour
{

    public LayerMask mask;
    [SerializeField] private GameObject parentObject;

    void Start()
    {

    }


    void Update()
    {
        MouseClick();

    }

    void MouseClick()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("ilk");
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit;

            if (Physics.Raycast(ray, out hit, mask))
            {
                Debug.Log("ikii");
                hit.collider.gameObject.GetComponentInParent<GroundStats>().mouseCheck = true;
                parentObject = hit.collider.gameObject.transform.parent.gameObject;
            }
            else
            {
                parentObject.GetComponent<GroundStats>().mouseCheck = false;
            }
        }

    }
}