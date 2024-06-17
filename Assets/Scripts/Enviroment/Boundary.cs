using System;

namespace InviromentSpace
{
    [Serializable]
    public class PlayerBoundary
    {
        public float _xMin, _xMax, _zMin, _zMax;
    }
    
    [Serializable]
    public class AsteroidBoundary
    {
        public float _xMin, _xMax;
    }
}