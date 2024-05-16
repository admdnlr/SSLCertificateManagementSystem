namespace SSLCertificateManagementSystem.Data
{
    public class Certificate
    {
        public int Id { get; set; }
        public string CertificateName { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string IssuedBy { get; set; }
        public string Status { get; set; }
    }
}
