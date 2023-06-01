using UnityEngine;

public class ToggleGameObject : MonoBehaviour
{
    public GameObject objectToToggle;

    public void ToggleObject()
    {
        objectToToggle.SetActive(!objectToToggle.activeSelf);
    }
}