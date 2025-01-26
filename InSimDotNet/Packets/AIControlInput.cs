namespace InSimDotNet.Packets
{
    public enum AIControlInput
    {
        CS_MSX = 0,
        CS_THROTTLE = 1,
        CS_BRAKE = 2,
        CS_CHUP = 3,
        CS_CHDN = 4,
        CS_IGNITION = 5,
        CS_EXTRALIGHT = 6,
        CS_HEADLIGHTS = 7,
        CS_SIREN = 8,
        CS_HORN = 9,
        CS_FLASH = 10,
        CS_CLUTCH = 11,
        CS_HANDBRAKE = 12,
        CS_INDICATORS = 13,
        CS_GEAR = 14,
        CS_LOOK = 15,
        CS_PITSPEED = 16,
        CS_TCDISABLE = 17,
        CS_FOGREAR = 18,
        CS_FOGFRONT = 19,
        CS_NUM = 20,
        CS_SEND_AI_INFO = 240,
        CS_SEND_REPEAT_AI_INFO = 241,
        CS_SET_HELP_FLAGS = 253,
        CS_RESET_INPUTS = 254,
        CS_STOP_CONTROL = 255
    }
}
