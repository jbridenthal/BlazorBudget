namespace BlazorBudget.Models
{
    public class BudgetItemModel
    {
        public Guid Id { get; set; }
        public Guid BudgetId { get; set; }
        public string? BudgetItemName { get; set; }
        public double BudgetItemAmount { get; set; }
    }
}
