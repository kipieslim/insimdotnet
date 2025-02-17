using System;

namespace InSimDotNet.Packets {
    /// <summary>
    /// Represents the <see cref="IS_BTN"/> BStyle.
    /// </summary>
    [Flags]
    public enum ButtonStyles {
        /// <summary>
        /// Colour 0: Light grey.
        /// </summary>
        ISB_C0 = 0,
        /// <summary>
        /// Colour 1: Title colour.
        /// </summary>
        ISB_C1 = 1,

        /// <summary>
        /// Colour 2: Unselected text
        /// </summary>
        ISB_C2 = 2,

        /// <summary>
        /// Colour 3: Selected text
        /// </summary>
        ISB_C3 = 3,

        /// <summary>
        /// Colour 4: ok
        /// </summary>
        ISB_C4 = 4,

        /// <summary>
        /// Colour 5: cancel
        /// </summary>
        ISB_C5 = 5,

        /// <summary>
        /// Colour 6: text string
        /// </summary>
        ISB_C6 = 6,

        /// <summary>
        /// Colour 7: unavailable
        /// </summary>
        ISB_C7 = 7,

        /// <summary>
        /// When clicked this button will send a <see cref="IS_BTC"/> packet.
        /// </summary>
        ISB_CLICK = 8,

        /// <summary>
        /// Light button.
        /// </summary>
        ISB_LIGHT = 16,

        /// <summary>
        /// Dark button.
        /// </summary>
        ISB_DARK = 32,

        /// <summary>
        /// Align text to left.
        /// </summary>
        ISB_LEFT = 64,

        /// <summary>
        /// Align text to right.
        /// </summary>
        ISB_RIGHT = 128,
    }
}
