using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LookItem : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IGvrPointerHoverHandler
{

    private Animator anim;
    private readonly int hashIsOpen = Animator.StringToHash("IsOpen");

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void OnBoxOpen(bool isOpen)
    {
        anim.SetBool(hashIsOpen, isOpen);
    }

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