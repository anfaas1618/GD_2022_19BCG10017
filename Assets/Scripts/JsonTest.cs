using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
[Serializable]
public class JsonTest
{
    public pulpit_data pulpit_data;
    public player_data player_data;

}
[Serializable]
public class pulpit_data
{
    public float min_pulpit_destroy_time;
    public float max_pulpit_destroy_time;
    public float pulpit_spawn_time;
}
[Serializable]
public class player_data
{
    public float speed;
}



