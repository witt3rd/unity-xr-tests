using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTests : MonoBehaviour
{
    [SerializeField] private InputControls _controls;
    [SerializeField] private Material selected;

    private void OnEnable()
    {
        _controls.QPortalUser.Movement.performed += Movement_performed;
        _controls.QPortalUser.Movement.Enable();
    }
    private void OnDisable()
    {
        _controls.QPortalUser.Movement.performed -= Movement_performed;
        _controls.QPortalUser.Movement.Disable();
    }

    private void Movement_performed(UnityEngine.Experimental.Input.InputAction.CallbackContext context)
    {
        Debug.Log("movement");


        GameObject plane = GameObject.CreatePrimitive(PrimitiveType.Plane);

        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = new Vector3(0, 0.5f, 0);

        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.position = new Vector3(0, 1.5f, 0);
        sphere.GetComponent<Renderer>().material = selected;

        GameObject capsule = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        capsule.transform.position = new Vector3(2, 1, 0);

        GameObject cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        cylinder.transform.position = new Vector3(-2, 1, 0);
    }
}
