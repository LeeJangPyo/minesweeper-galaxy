﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Define
{
    public enum Scene
    {
        Unknown,
        Login,
        Lobby,
        Game,
    }

    public enum Sound
    {
        Bgm,
        Effect,
        MaxCount,
    }

    public enum UIEvent
    {
        Click,
        Drag,
    }

    public enum MouseEvent
    {
        Press,
        Click,
        RPress,
        RClick,
    }

    public enum CameraMode
    {
        QuarterView,
    }

    public enum CellState
    {
        CLOSE,
        ONE,        //주변 지뢰 개수
        TWO,
        THREE,
        FOUR,
        FIVE,
        SIX,
        SEVEN,
        EIGHT,
        NINE,
        FLAG,       //깃발 상태
        OPEN,       //열림 상태   
        MINE,       //지뢰
    }

    public static int[] xIndex = { -1, 0, 1, -1, 0, 1, -1, 0, 1 };
    public static int[] yIndex = { -1, -1, -1, 0, 0, 0, 1, 1, 1 };

}
