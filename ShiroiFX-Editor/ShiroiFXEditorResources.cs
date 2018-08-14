﻿using UnityEngine;

namespace Shiroi.FX.Editor {
    public static class ShiroiFXEditorResources {
        public static readonly GUIContent FXName = new GUIContent("FX Name", "The name of the effect");
        public static readonly GUIContent EditFX = new GUIContent("Edit FX", "Selects the effect for editing");

        public static readonly GUIContent RemoveFX = new GUIContent(
            "Remove FX",
            "Removes this effect from the composite effect"
        );

        public static readonly GUIContent NullFXError = new GUIContent(
            "Null effect found!",
            "There is a null effect on the composite effect, please remove it."
        );

        public static readonly GUIContent AddEffect = new GUIContent("Add Effect", "Adds a new effect to the list");

        public static readonly GUIContent WorldFXHeader = new GUIContent(
            "World Effects",
            "All of the world effects in this composite"
        );

        public static readonly GUIContent GameFXHeader = new GUIContent(
            "Game Effects",
            "All of the game effects in this composite"
        );

        public const string BasePath = "Shiroi/FX/";
        public const string BaseCreatePath = "Assets/Create/" + BasePath;
    }
}