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

    private Building _correspondingBuilding;
    public Building correspondingBuilding
    {
        get
        {
            if (_correspondingBuilding == null)
            {
                _correspondingBuilding = GetComponentInChildren<Building>();
            }
            return _correspondingBuilding;
        }
        set
        {
            _correspondingBuilding = value;
        }
    }
   
    [SerializeField] private int _actionSet = 0;
    public int ActionSet
    {
        get
        {
            return _actionSet;
        }
        set
        {
            _actionSet = value;
            ActionController.SetUpInteractable(value);
        }
    } 

    public bool isSelected => selected == this;

    public void UpActionSet() => ActionSet++;

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

        gameObject.transform.localScale = Vector3.one * 3.4f;
    }

    public virtual void DeSelect()
    {
        Debug.Log("DeSelected");
        selected = null;

        gameObject.transform.localScale = Vector3.one * 3f;
    }
}

