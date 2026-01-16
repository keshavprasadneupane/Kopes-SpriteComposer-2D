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

namespace Kope.SpriteComposer2D
{
    /// <summary>
    /// Example implementation of CustomSpriteLibraryDefination for body regions.
    /// Used to manage sprite overrides for different body regions.
    /// uses BodyRegionEnum as the generic type parameter.
    /// Any Enum representing body regions can be used here.
    /// but 0 in the enum should represent 'none' or 'undefined' state.
    /// other values should represent valid body regions.
    /// </summary>
    public class BodyRegionSpriteLibrary : CustomSpriteLibraryDefination<BodyRegionEnum> { }
}