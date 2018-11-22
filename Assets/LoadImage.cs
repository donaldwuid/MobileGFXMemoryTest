using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LoadImage : MonoBehaviour {

    public string path1;
    private bool m_didLoad = false;
    public void OnClick(BaseEventData e)
    {
        if(!m_didLoad)
        {
            m_didLoad = true;
            GameObject prefab;
            prefab = Resources.Load<GameObject>(path1);
            Instantiate(prefab, transform);
        }
    }
}
