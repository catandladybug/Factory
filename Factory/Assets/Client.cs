using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    public NPCSpawner m_SpawnNPC;

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            m_SpawnNPC.SpawnVillagers();
        }
    }
}
