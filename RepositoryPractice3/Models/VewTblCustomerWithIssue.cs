namespace RepositoryPractice3.Models
{
    public class VewTblCustomerWithIssue
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int IssueId { get; set; }
        public string Problem { get; set; }
        public string PaymentStatus { get; set; }
        public string WorkStatus { get; set; }
    }
}
