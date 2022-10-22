using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereColorController : MonoBehaviour, IClicktable
{

    public List<Color> colors = new List<Color>();



    private void SetSphereColor()
    {
        StartCoroutine(SetColor());
    }



    IEnumerator SetColor()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = colors[1];
        yield return new WaitForSeconds(1);
        gameObject.GetComponent<MeshRenderer>().material.color = colors[0];
    }



    public void Click()
    {
        SetSphereColor();
    }
}
