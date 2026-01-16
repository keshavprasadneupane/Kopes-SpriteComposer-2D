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

public static class EnumExtension
{
    public static string ToIdPart(this System.Enum enumValue)
    {
        return enumValue.ToString().ToLowerInvariant().Replace(" ", "_");
    }
}
