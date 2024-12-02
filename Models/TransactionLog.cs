namespace ProductWebApp.Models
{
    public class TransactionLog
    {
        public int Id { get; set; } // Primary key
        public string ActionType { get; set; } // CRUD action type: "Create", "Update", "Delete"
        public string ProductName { get; set; } // Name of the product involved
        public int ProductId { get; set; } // ID of the product involved
        public DateTime Timestamp { get; set; } // Timestamp of the action
        public string UserName { get; set; } // User who performed the action (optional)
        public string Details { get; set; } // Any additional details about the transaction
    }
}
