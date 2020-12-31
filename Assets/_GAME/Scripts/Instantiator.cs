using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Instantiator : ScriptableObject
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

    public void InstantiatePrefab(HitInfos p_Infos)
    {
        Instantiate(m_Prefab, p_Infos.impact, Quaternion.identity);
    }
    public void InstantiatePrefab(ShootInfos p_Infos)
    {
        Instantiate(m_Prefab, p_Infos.origin, Quaternion.identity);
    }
    


}
