using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Selectable : MonoBehaviour, IPointerClickHandler
{
    private static Selectable _selected;
    public static Selectable selected
    {
        get
        {
            return _selected;
        }
        private set
        {
            _selected = value;
            ActionController.SetUpInteractable(value != null ? value.ActionSet : 0);
        }

    }
   
    [SerializeField] private int _actionSet = 0;
    public int ActionSet => _actionSet;

    public bool isSelected => selected == this;

    void IPointerClickHandler.OnPointerClick(PointerEventData eventData)
    {
        if(this != selected)
        {
            Select();
        }
        else
        {
            DeSelect();
        }
    }

    private void OnMouseDown()
    {
        if (this != selected)
        {
            Select();
        }
        else
        {
            DeSelect();
        }
    }

    protected virtual void Move()
    {
        if(selected != this)
        {
            return;
        }

    }

    protected virtual void Select()
    {
        Debug.Log("Selected");
        selected?.DeSelect();
        selected = this;
    }

    public virtual void DeSelect()
    {
        Debug.Log("DeSelected");
        selected = null;
    }
}

