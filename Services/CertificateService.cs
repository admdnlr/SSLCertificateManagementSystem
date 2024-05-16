using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SSLCertificateManagementSystem.Data;

namespace SSLCertificateManagementSystem.Services
{
    public class CertificateService
    {
        private readonly ApplicationDbContext _context;

        public CertificateService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Certificate>> GetAllCertificatesAsync()
        {
            return await _context.Certificates.ToListAsync();
        }

        public async Task AddCertificateAsync(Certificate certificate)
        {
            _context.Certificates.Add(certificate);
            await _context.SaveChangesAsync();
        }

        // Diğer CRUD operasyonları
    }
}
