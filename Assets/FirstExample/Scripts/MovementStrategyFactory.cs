using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MovementStrategyFactory
{
    private Transform _target;
    private List<Transform> _patrolPoint = new List<Transform>();

    public MovementStrategyFactory(Transform target, List<Transform> patrolPoints)
    {
        _target = target;
        _patrolPoint = new List<Transform>(patrolPoints);
    }

    public IMover Get(MoverTypes moverType, IMovable movable)
    {
        switch (moverType)
        {
            case MoverTypes.NoMove:
                return new NoMovePattern();

            case MoverTypes.PointByPoint:
                return new PointByPointMover(movable, _patrolPoint.Select(point => point.position));

            case MoverTypes.TargetFollower:
                return new MoveToTargetPattern(movable, _target);

            default:
                throw new ArgumentException(nameof(moverType));
        }
    }
}
