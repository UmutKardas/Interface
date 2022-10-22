using UnityEngine;

public class ClickController : MonoBehaviour
{

    private Ray ray;
    private RaycastHit hit;
    public LayerMask layer;



    void Update()
    {
        SetClick();
    }



    private void SetClick()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit, Mathf.Infinity, layer))
            {
                IClicktable clicktable = hit.collider.GetComponent<IClicktable>();
                if (clicktable != null)
                {
                    clicktable.Click();
                }
            }
        }
    }
}
