using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;

public class Hotspot : MonoBehaviour
{

    public GameObject ThisPanorama;
    public GameObject TargetPanorama;

    // Update is called once per frame
    void Update()
    {

    }

    public void OnMouseDown()
    {
        OnMouseExit();
        OnHotspotTransition();
    }

    public void OnMouseOver()
    {
        transform.DOScale(new Vector3(0.08f, 0.08f, 0.08f), 0.3f);
    }

    public void OnMouseExit()
    {
        transform.DOScale(new Vector3(0.05f, 0.05f, 0.05f), 0.3f);
    }

    public void OnHotspotTransition()
    {
        SetSkyBox();
    }

    private void SetSkyBox()
    {
        if (TourManager.SetCameraPosition != null)
            TourManager.SetCameraPosition(TargetPanorama.transform.position, ThisPanorama.transform.position);
        TargetPanorama.gameObject.SetActive(true);
        ThisPanorama.gameObject.SetActive(false);
    }
}