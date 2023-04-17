using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

public class System_Movement :ComponentSystem
{
    protected override void OnUpdate()
    {
        Entities.ForEach((ref Data_Movement data_Movement) => {
            data_Movement.direction += Vector2.one * Time.DeltaTime;
        });
    }
}
