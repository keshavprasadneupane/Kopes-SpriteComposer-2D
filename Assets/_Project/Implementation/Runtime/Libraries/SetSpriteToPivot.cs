// ==============================================================================
// Kope's SpriteComposer 2D
// © 2026 Keshav Prasad Neupane ("Kope")
// License: MIT License (See LICENSE.md in project root)
//
// Overview:
// A comprehensive framework for Unity designed for modular character assembly.
// Allows building characters from independent body parts and equipment while
// keeping animations synchronized through a data-driven approach.
// ==============================================================================

using UnityEngine;
public class SetSpriteToPivot : MonoBehaviour
{
    [SerializeField] private SpriteRenderer sr;
    private void Awake() => sr.spriteSortPoint = SpriteSortPoint.Pivot;
}