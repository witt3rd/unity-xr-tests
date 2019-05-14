using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionController : MonoBehaviour
{
    [SerializeField] public GameObject kindObject;

        public void OnCreateKind()
    {
        Instantiate(kindObject, new Vector3(0, 10, .1F), Quaternion.identity);

    }

}
