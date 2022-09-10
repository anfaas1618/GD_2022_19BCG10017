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
    public int min_pulpit_destroy_time;
    public int max_pulpit_destroy_time;
    public double pulpit_spawn_time;
}
[Serializable]
public class player_data
{
    public int speed;
}



