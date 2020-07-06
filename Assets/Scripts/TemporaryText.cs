using System.Collections;
using UnityEngine;

public class TemporaryText : MonoBehaviour
{
    [SerializeField] float displayTime = 3f;
    void OnEnable()
    {
        StartCoroutine(ShowAndHide());
    }
    IEnumerator ShowAndHide()
    {
        yield return new WaitForSeconds(displayTime);
        this.gameObject.SetActive(false);
    }
}
