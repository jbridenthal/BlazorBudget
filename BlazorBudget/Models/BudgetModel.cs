namespace BlazorBudget.Models
{
    public class BudgetModel
    {
        public Guid Id { get; set; }
        public string? BudgetName { get; set; }
        public double BudgetAmount { get; set; }
        public IEnumerable<BudgetItemModel>? BudgetItems { get; set; }

    }
}
