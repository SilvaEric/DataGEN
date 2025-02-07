namespace GeradorDadosAPI.Models
{
    public class ServerDetails
    {
        public string MachineName { get; set; } = Environment.MachineName;
        public int ProcessId { get; set; } = Environment.ProcessId;
        public int ThreaId { get; set; } = Environment.CurrentManagedThreadId;
    }
}
