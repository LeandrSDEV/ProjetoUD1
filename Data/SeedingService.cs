using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Plugins;
using ProjetoUd1.Models;
using ProjetoUd1.Models.Enums;

namespace ProjetoUd1.Data
{
    public class SeedingService
    {
        private readonly BancoContext _bancoContext;
        public SeedingService(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public void Seed()
        {
            if(_bancoContext.Departments.Any() || _bancoContext.Seller.Any() || _bancoContext.SalesRecord.Any())
            {
                return;
            }

            DepartmentModel d1 = new DepartmentModel(1, "Computers");
            DepartmentModel d2 = new DepartmentModel(2, "Electronics");
            DepartmentModel d3 = new DepartmentModel(3, "Fashion");
            DepartmentModel d4 = new DepartmentModel(4, "Books");

            SellerModel s1 = new SellerModel(1, "Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
            SellerModel s2 = new SellerModel(2, "Maria Green", "maria@gmail.com", new DateTime(1979, 12, 31), 3500.0, d2);
            SellerModel s3 = new SellerModel(3, "Alex Grey", "alex@gmail.com", new DateTime(1988, 1, 15), 2200.0, d1);
            SellerModel s4 = new SellerModel(4, "Martha Red", "martha@gmail.com", new DateTime(1993, 11, 30), 3000.0, d4);
            SellerModel s5 = new SellerModel(5, "Donald Blue", "donald@gmail.com", new DateTime(2000, 1, 9), 4000.0, d3);
            SellerModel s6 = new SellerModel(6, "Alex Pink", "bob@gmail.com", new DateTime(1997, 3, 4), 3000.0, d2);

            SalesRecordModel r1 = new SalesRecordModel(1, new DateTime(2018, 09, 25), 11000.0, SaleStatus.Billed, s1);
            SalesRecordModel r2 = new SalesRecordModel(2, new DateTime(2018, 09, 4), 7000.0, SaleStatus.Billed, s5);
            SalesRecordModel r3 = new SalesRecordModel(3, new DateTime(2018, 09, 13), 4000.0, SaleStatus.Canceled, s4);
            SalesRecordModel r4 = new SalesRecordModel(4, new DateTime(2018, 09, 1), 8000.0, SaleStatus.Billed, s1);
            SalesRecordModel r5 = new SalesRecordModel(5, new DateTime(2018, 09, 21), 3000.0, SaleStatus.Billed, s3);
            SalesRecordModel r6 = new SalesRecordModel(6, new DateTime(2018, 09, 15), 2000.0, SaleStatus.Billed, s1);
            SalesRecordModel r7 = new SalesRecordModel(7, new DateTime(2018, 09, 28), 13000.0, SaleStatus.Billed, s2);
            SalesRecordModel r8 = new SalesRecordModel(8, new DateTime(2018, 09, 11), 4000.0, SaleStatus.Billed, s4);
            SalesRecordModel r9 = new SalesRecordModel(9, new DateTime(2018, 09, 14), 11000.0, SaleStatus.Pending, s6);
            SalesRecordModel r10 = new SalesRecordModel(10, new DateTime(2018, 09, 7), 9000.0, SaleStatus.Billed, s6);
            SalesRecordModel r11 = new SalesRecordModel(11, new DateTime(2018, 09, 13), 6000.0, SaleStatus.Billed, s2);
            SalesRecordModel r12 = new SalesRecordModel(12, new DateTime(2018, 09, 25), 7000.0, SaleStatus.Pending, s3);
            SalesRecordModel r13 = new SalesRecordModel(13, new DateTime(2018, 09, 29), 10000.0, SaleStatus.Billed, s4);
            SalesRecordModel r14 = new SalesRecordModel(14, new DateTime(2018, 09, 4), 3000.0, SaleStatus.Billed, s5);
            SalesRecordModel r15 = new SalesRecordModel(15, new DateTime(2018, 09, 12), 4000.0, SaleStatus.Billed, s1);
            SalesRecordModel r16 = new SalesRecordModel(16, new DateTime(2018, 10, 5), 2000.0, SaleStatus.Billed, s4);
            SalesRecordModel r17 = new SalesRecordModel(17, new DateTime(2018, 10, 1), 12000.0, SaleStatus.Billed, s1);
            SalesRecordModel r18 = new SalesRecordModel(18, new DateTime(2018, 10, 24), 6000.0, SaleStatus.Billed, s3);
            SalesRecordModel r19 = new SalesRecordModel(19, new DateTime(2018, 10, 22), 8000.0, SaleStatus.Billed, s5);
            SalesRecordModel r20 = new SalesRecordModel(20, new DateTime(2018, 10, 15), 8000.0, SaleStatus.Billed, s6);
            SalesRecordModel r21 = new SalesRecordModel(21, new DateTime(2018, 10, 17), 9000.0, SaleStatus.Billed, s2);
            SalesRecordModel r22 = new SalesRecordModel(22, new DateTime(2018, 10, 24), 4000.0, SaleStatus.Billed, s4);
            SalesRecordModel r23 = new SalesRecordModel(23, new DateTime(2018, 10, 19), 11000.0, SaleStatus.Canceled, s2);
            SalesRecordModel r24 = new SalesRecordModel(24, new DateTime(2018, 10, 12), 8000.0, SaleStatus.Billed, s5);
            SalesRecordModel r25 = new SalesRecordModel(25, new DateTime(2018, 10, 31), 7000.0, SaleStatus.Billed, s3);
            SalesRecordModel r26 = new SalesRecordModel(26, new DateTime(2018, 10, 6), 5000.0, SaleStatus.Billed, s4);
            SalesRecordModel r27 = new SalesRecordModel(27, new DateTime(2018, 10, 13), 9000.0, SaleStatus.Pending, s1);
            SalesRecordModel r28 = new SalesRecordModel(28, new DateTime(2018, 10, 7), 4000.0, SaleStatus.Billed, s3);
            SalesRecordModel r29 = new SalesRecordModel(29, new DateTime(2018, 10, 23), 12000.0, SaleStatus.Billed, s5);
            SalesRecordModel r30 = new SalesRecordModel(30, new DateTime(2018, 10, 12), 5000.0, SaleStatus.Billed, s2);

            _bancoContext.Departments.AddRange(d1, d2, d3, d4);

            _bancoContext.Seller.AddRange(s1, s2, s3, s4, s5, s6);

            _bancoContext.SalesRecord.AddRange(
                r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
                r21, r22, r23, r24, r25, r26, r27, r28, r29, r30
            );

            _bancoContext.SaveChanges();
        }
    }
}
