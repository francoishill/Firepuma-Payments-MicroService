namespace Firepuma.PaymentsService.FunctionAppManager.Commands.Results;

public class CreateQueueResult
{
    public string QueueName { get; set; }
    public bool IsNew { get; set; }
    public object QueueProperties { get; set; }
    public string ConnectionString { get; set; }
}