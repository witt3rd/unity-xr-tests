using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionManager : MonoBehaviour
{
    public GameObject thing;

    public void Button()
    {
        Instantiate(thing, new Vector3(0.0F, 10.0F, -0.5F), Quaternion.identity);
        Debug.Log("Button pressed");
    }
}
