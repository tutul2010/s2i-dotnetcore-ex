namespace app.Models;

public class ErrorViewModel
{
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    public string? systemInfo { get; set; }
    public bool showSystemInfo => !string.IsNullOrEmpty(systemInfo);
}
