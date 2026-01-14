namespace ShellBat.Utilities;

// https://learn.microsoft.com/en-us/windows/console/console-virtual-terminal-sequences
// https://invisible-island.net/xterm/ctlseqs/ctlseqs.html
public enum TerminalSequenceCode
{
    RI,         // Reverse Index 
    DECSC,      // Save Cursor Position in Memory
    DECSR,      // Restore Cursor Position from Memory
    DECSET,     // CSI ? Pm h  DEC Private Mode Set (DECSET).
    DECRST,     // CSI ? Pm l  DEC Private Mode Reset (DECRST).

    CUU,        // Cursor Up
    CUD,        // Cursor Down
    CUF,        // Cursor Forward
    CUB,        // Cursor Back
    CNL,        // Cursor Next Line
    CPL,        // Cursor Previous Line
    CHA,        // Cursor Horizontal Absolute
    VPA,        // Vertical Position Absolute
    CUP,        // Cursor Position
    HVP,        // Horizontal and Vertical Position
    ANSISYSSC,  // Save Cursor Position (ANSI.SYS)
    ANSISYSRC,  // Restore Cursor Position (ANSI.SYS)

    DECSCUSR,   // Set Cursor Style

    SU,         // Scroll Up
    SD,         // Scroll Down

    ICH,        // Insert Character  
    DCH,        // Delete Character
    ECH,        // Erase Character
    IL,         // Insert Line
    DL,         // Delete Line

    ED,         // Erase in Display
    EL,         // Erase in Line

    SGR,        // Select Graphic Rendition

    DECKPAM,    // Keypad Application Mode
    DECKPNM,    // Keypad Numeric Mode

    DECXCPR,    // Request Cursor Position Report
    DA,         // Device Attributes

    HTS,        // Horizontal Tab Set
    CHT,        // Cursor Horizontal Tab
    CBT,        // Cursor Backward Tab
    TBC_CURRENT,    // Tab Clear
    TBC_ALL,        // Tab Clear

    DECSTBM,    // Set Scrolling Region

    DECSTR,      // Soft Terminal Reset

    // specific to us
    DCS_DEC,    // Designate Character Set
    DCS_ASCII,  // Designate Character Set
    CUSTOM_OSC, // Operating System Command
    RAW,        // Raw data
    UNSUPPORTED // Unsupported sequence
}
