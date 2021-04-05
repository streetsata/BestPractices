namespace SolidPrincples.OCP.Model
{
    public enum MonitorType
    {
        OLED,
        LCD,
        LED
    }
    public enum Screen
    {
        WideScreen,
        CurvedScreen
    }
    internal class ComputerMonitor
    {
        public string Name { get; set; }
        public MonitorType Type { get; set; }
        public Screen Screen { get; set; }
    }
}
