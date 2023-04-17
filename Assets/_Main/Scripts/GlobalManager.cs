using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Transforms;
using Unity.Collections;

public class GlobalManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        EntityManager entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;

        EntityArchetype entityArchetype = entityManager.CreateArchetype(typeof(Data_Movement), typeof(Translation));
        NativeArray<Entity> entityArray = new NativeArray<Entity>(20000, Allocator.Temp);
        entityManager.CreateEntity(entityArchetype, entityArray);
        for (int i = 0; i < entityArray.Length; i++)
        {
            Entity entity = entityArray[i];
            entityManager.SetComponentData(entity, new Data_Movement { direction = new Vector2(Random.Range(0,10), 1) });
        }
        entityArray.Dispose();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
