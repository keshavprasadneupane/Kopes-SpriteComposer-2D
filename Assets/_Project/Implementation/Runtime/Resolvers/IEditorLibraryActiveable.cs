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
namespace Kope.SpriteComposer2D
{
    /// <summary>
    /// Interface for editor library activeable components.
    /// Implement this interface to allow setting active category and label in the editor.
    /// </summary>
    public abstract class IEditorLibraryActiveable : MonoBehaviour
    {

        public abstract void SetActiveCategoryAndLabel(string category, string label);
    }
}