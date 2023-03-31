using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTP2
{
    [TestClass]
    public class ReportGeneratorTests
    {
        [TestMethod]
        public void TestGenerateCsvReport()
        {
            // Arrange
            ReportBuilder builder = new ReportBuilder();
            builder.AddDataSource(new DataSource() { ConnectionString = "localdb", Name ="Local DB"});
            builder.AddFilter(new Filter() { Field ="Region", Value = "North" });
            builder.AddVisualization(new Visualization() { Source = "CSV", Type = "Bar Chart" });

            // Act
            Report csvReport = builder.GetReport();

            // Assert
            Assert.IsNotNull(csvReport);
            Assert.IsTrue(csvReport.Filters[0].Field == "Region");
            Assert.IsTrue(csvReport.Filters[0].Field == "North");
        }

        [TestMethod]
        public void TestGeneratePdfReport()
        {
            // Arrange
            ReportBuilder builder = new ReportBuilder();
            Report report = builder.WithDataSource(new DatabaseDataSource())
                                   .WithFilter(new FilterByColumnValue("Region", "South"))
                                   .WithVisualization(new PieChart())
                                   .Build();

            // Act
            byte[] pdfReport = report.GeneratePdfReport();

            // Assert
            Assert.IsNotNull(pdfReport);
            Assert.IsTrue(pdfReport.Length > 0);
        }

        [TestMethod]
        public void TestGenerateHtmlReport()
        {
            // Arrange
            ReportBuilder builder = new ReportBuilder();
            Report report = builder.WithDataSource(new SpreadsheetDataSource())
                                   .WithFilter(new FilterByColumnValue("Region", "East"))
                                   .WithVisualization(new LineChart())
                                   .Build();

            // Act
            string htmlReport = report.GenerateHtmlReport();

            // Assert
            Assert.IsNotNull(htmlReport);
            Assert.IsTrue(htmlReport.Contains("<html>"));
            Assert.IsTrue(htmlReport.Contains("<head>"));
            Assert.IsTrue(htmlReport.Contains("<body>"));
            Assert.IsTrue(htmlReport.Contains("</html>"));
            Assert.IsTrue(htmlReport.Contains("</head>"));
            Assert.IsTrue(htmlReport.Contains("</body>"));
        }
    }

}
