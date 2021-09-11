using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public List<GameObject> m_Objects;
    private GameObject m_ObjectSpawn;

    public float maxPosX, minPosX, maxPosZ, minPosZ;
    private float posX, posZ;

    private void Start()
    {
        SpawnObject();
    }

    public void SpawnObject()
    {
        TakeObject();
        SetPositionChange();
        m_ObjectSpawn.active = true;
        m_ObjectSpawn.transform.localPosition += new Vector3(posX,  0, posZ);
    }

    private void TakeObject()
    {
        if (m_Objects.Count > 1)
        {
            m_ObjectSpawn = m_Objects[Random.Range(0, m_Objects.Count - 1)];
        }
        else 
        {
            m_ObjectSpawn = m_Objects[0];
        }
    }

    private void SetPositionChange()
    {
        posX = Random.Range(minPosX, maxPosX);
        posZ = Random.Range(minPosZ, maxPosZ);
    }
}
