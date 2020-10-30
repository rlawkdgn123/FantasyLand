using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LookItem : MonoBehaviour,IPointerEnterHandler,
    IPointerExitHandler,IGvrPointerHoverHandler
{
    public void OnLookItemBox(bool isLookAt)
    {
        Debug.Log(isLookAt);
        MoveCtrl.isStopped = isLookAt;
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        MoveCtrl.isStopped = true;
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        MoveCtrl.isStopped = false;
    }
    public void OnGvrPointerHover(PointerEventData eventData)
    {
        Debug.Log("Reticle On");
    }
}
