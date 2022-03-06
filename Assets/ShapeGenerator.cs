using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeGenerator : MonoBehaviour
{
    private ShapeSettings settings;

    public ShapeGenerator(ShapeSettings settings)
    {
        this.settings = settings;
    }

    public Vector3 CalculatePointInPlanet(Vector3 pointOnUnitSphere)
    {
        return pointOnUnitSphere * settings.planetRadius;
    }
}
