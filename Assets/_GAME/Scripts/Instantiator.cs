using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiator : MonoBehaviour
{
    [SerializeField]
    private GameObject m_Prefab = null;
    public void InstantiatePrefab(GameObject p_Prefab)
    {
        Instantiate(p_Prefab);
    }

    public void InstantiatePrefab(CollectInfos p_Infos)
    {
        Instantiate(m_Prefab, p_Infos.position, Quaternion.identity);
    }
}
