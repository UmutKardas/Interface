using System.Collections;
using UnityEngine;

public class CubeSetActiveController : MonoBehaviour, IClicktable
{

    private void SetCubeActive()
    {
        StartCoroutine(SetActive());
    }



    IEnumerator SetActive()
    {
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        yield return new WaitForSeconds(1);
        gameObject.GetComponent<MeshRenderer>().enabled = true;
    }



    public void Click()
    {
        SetCubeActive();
    }
}
