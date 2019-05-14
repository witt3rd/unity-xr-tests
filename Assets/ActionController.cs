using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionController : MonoBehaviour
{
    [SerializeField] public GameObject kindObject;
    [SerializeField] public GameObject functionObject;

    public void OnCreateKind()
    {
        Instantiate(kindObject, new Vector3(0, 3, .1F), Quaternion.identity);

    }
    public void OnCreateFunction()
    {
        Instantiate(functionObject, new Vector3(0, 3, .1F), Quaternion.identity);

    }

}
