using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverOutline : MonoBehaviour
{

    public GameObject Object;

    private void OnMouseOver() {
        var outline = Object.AddComponent<Outline>();

    outline.OutlineMode = Outline.Mode.OutlineAll;
    outline.OutlineColor = Color.yellow;
    outline.OutlineWidth = 5f;
    }


}
