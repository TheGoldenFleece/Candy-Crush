using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Tile : MonoBehaviour
{
    static public Tile selected;
    public Vector2Int position;
    SpriteRenderer renderer;
    [SerializeField] Color selectColor;
    Color defaultColor;

    private void Awake()
    {
        renderer = GetComponent<SpriteRenderer>();
        defaultColor = renderer.color;
    }

    void Select()
    {
        renderer.color = selectColor;
    }
    void Unselect()
    {
        renderer.color = defaultColor;
    }

    private void OnMouseDown()
    {
        if (selected == null)
        {
            selected = this;
            Select();

            return;
        }

        if (selected == this)
        {
            selected = null;
            Unselect();

            return;
        }

        if (!GridManager.Instance.IsSwaping && Vector2Int.Distance(position, selected.position) == 1)
        {
            StartCoroutine(GridManager.Instance.Swap(position, selected.position));
            selected.Unselect();
            selected = null;

            return;
        }
        else
        {
            selected.Unselect();
            Select();
            selected = this;
        }
    }

}
